using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioFrequencyParticleManager : MonoBehaviour
{
    [Header("Configuración general")]
    public float amplitudeMultiplier = 10.0f;
    public float noiseThreshold = 0.01f; // Valor mínimo para activar emisión

    [Header("Spawners de partículas")]
    public ParticleSystem[] particleSpawners = new ParticleSystem[12];

    private AudioSource audioSource;
    private float[] spectrumData = new float[512];
    private float[] frequencyBands = new float[12];

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Microphone.Start(null, true, 10, AudioSettings.outputSampleRate);
        audioSource.loop = true;

        while (!(Microphone.GetPosition(null) > 0)) { }
        audioSource.Play();
    }

    void Update()
    {
        audioSource.GetSpectrumData(spectrumData, 0, FFTWindow.BlackmanHarris);
        MakeFrequencyBands();
        UpdateParticleSystems();
    }

    void MakeFrequencyBands()
    {
        int count = 0;

        for (int i = 0; i < 12; i++)
        {
            int sampleCount = (int)Mathf.Pow(2, i + 1);
            float average = 0;

            if (i == 11) sampleCount += 2;

            for (int j = 0; j < sampleCount && count < spectrumData.Length; j++)
            {
                average += spectrumData[count] * (count + 1);
                count++;
            }

            average /= count;
            frequencyBands[i] = average * amplitudeMultiplier;
        }
    }

    void UpdateParticleSystems()
    {
        for (int i = 0; i < particleSpawners.Length && i < frequencyBands.Length; i++)
        {
            var bandValue = frequencyBands[i];

            var emission = particleSpawners[i].emission;

            if (bandValue > noiseThreshold)
            {
                emission.enabled = true;
                emission.rateOverTime = Mathf.Clamp(bandValue * 100f, 10, 500); // Puedes ajustar el rango
            }
            else
            {
                emission.enabled = false;
            }
        }
    }
}
