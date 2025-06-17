***Synthnestesia - v0.0.3***

Bitácora abierta de una exploración sinestésica en VR

Este repositorio contiene la versión 0.0.3, una prueba de concepto funcional desarrollada en Unity 2022.3.57f1 para dispositivos Android con integración del SDK de Google Cardboard. Esta versión está en una etapa temprana de desarrollo y no constituye un producto final, sino una serie de experimentos que buscan validar hipótesis técnicas y sensoriales en torno a la sinestesia simulada a través de realidad virtual.

Este espacio no solo recopila el código fuente y documentación técnica, sino que funciona como bitácora de desarrollo y canal de interacción con la comunidad. Tu retroalimentación es valiosa: el proyecto está concebido como un espacio abierto a la colaboración, el aprendizaje colectivo y la construcción compartida.

Este proyecto nace del deseo de expandir la percepción humana mediante tecnología inmersiva. Utilizando realidad virtual como medio, busca simular la sinestesia como fenómeno estético, mezclando estímulos auditivos y visuales en un entorno envolvente.

APK: https://drive.google.com/file/d/119-O8FNaVEEeyMC1ttv_PDeBWTQ2dtdo/view?usp=sharing

*Guía de instalación del proyecto en Unity pendiente*

**Bitácora de desarrollo**

v0.0.1 — Experimento 1: Captura y análisis de sonido

Se realizó una primera prueba de exploración para la captura de sonido a través del micrófono en Unity. Los datos fueron representados en 7 canales de frecuencia, impresos directamente en la consola para análisis.
Observaciones: Se evidenció una alta volatilidad en los valores de frecuencia, lo que plantea la necesidad de procesos de suavizado o normalización para futuras visualizaciones.

v0.0.2 — Experimento 2: Visualización en sliders

En esta segunda iteración, los datos de frecuencia fueron conectados a una interfaz visual mediante 7 sliders controlados por un manager. Se implementaron dos mejoras clave: un sistema de amplificación de la señal para mejorar la respuesta visual, y un suavizado para hacer más fluidos los movimientos de los sliders.

Conclusión: Esta metodología demostró ser viable para representar visualmente el sonido en tiempo real. Se identificó la importancia de normalizar los valores y aplicar suavizado para contrarrestar la inestabilidad inherente de los datos espectrales.

v0.0.3 — Experimento 3: Primer entorno en VR

Se evaluaron distintas formas de trasladar el experimento a un entorno de realidad virtual. Se consideró usar la plantilla oficial de Unity para VR, pero fue descartada por estar orientada a dispositivos de alta gama (como Oculus) y por su complejidad. La plantilla de Android también fue descartada al no facilitar un entorno VR desde cero. Finalmente, se optó por la plantilla oficial de Google Cardboard, por su enfoque en Android y su integración directa con visualización VR.

Se siguió la documentación y guía de instalación oficial de Google, aunque el proceso resultó complejo por la cantidad de parámetros requeridos para compilar correctamente.

La visualización evolucionó a 12 canales de frecuencia dispuestos en forma circular alrededor de la cámara, permitiendo una experiencia inmersiva en 360°, sin desplazamiento del usuario. Cada canal fue conectado a un spawner de partículas, similar a lo hecho con los sliders, pero en este caso con emisión visual dinámica.
Además, se añadieron variables expuestas en el inspector: amplificación, cantidad de partículas, y una función para ignorar ruido ambiental.

Conclusión: La herramienta de Google Cardboard demostró ser óptima para los objetivos del proyecto, y será usada como base para el desarrollo de la aplicación por su compatibilidad con Android y VR básico. Se detectaron dificultades al exportar skyboxes para Android, posiblemente por el uso de materiales tipo Skybox/6 Sided no compatibles o requerimientos especiales de URP. Se requiere más investigación.
Los resultados fueron prometedores: se logró una respuesta visual en tiempo real satisfactoria, aunque se deben seguir ajustando los efectos y trabajar en una identidad visual más definida.


***Synthnestesia - v0.0.3***

Open Logbook of a Synesthetic Exploration in VR

This repository contains version 0.0.3, a functional proof of concept developed in Unity 2022.3.57f1 for Android devices with Google Cardboard SDK integration. This version is in an early stage of development and is not a finished product, but rather a series of experiments aiming to validate technical and sensory hypotheses about simulated synesthesia through virtual reality.

This space not only compiles the source code and technical documentation, but also serves as a development logbook and channel for community interaction. Your feedback is valuable: the project is conceived as an open space for collaboration, collective learning, and shared creation.

This project was born from the desire to expand human perception through immersive technology. Using virtual reality as a medium, it aims to simulate synesthesia as an aesthetic phenomenon, blending auditory and visual stimuli in an enveloping environment.

APK: https://drive.google.com/file/d/119-O8FNaVEEeyMC1ttv_PDeBWTQ2dtdo/view?usp=sharing

**Development Log**

v0.0.1 — Experiment 1: Audio capture and analysis

The first experiment focused on capturing audio through the microphone in Unity. The data was split into 7 frequency bands and printed to the console for observation.
Observations: The frequency values showed high volatility, indicating the need for smoothing or normalization in future visual representations.

v0.0.2 — Experiment 2: Visual interface with sliders

In this iteration, frequency data was mapped to a visual interface using 7 sliders controlled by a manager. Two key improvements were introduced: a signal amplifier to enhance the visual response, and smoothing for a more fluid slider movement.

Conclusion: This method proved to be a viable way to visually represent real-time sound. The importance of normalizing values and applying smoothing was confirmed due to the inherent volatility of spectral data.

v0.0.3 — Experiment 3: First VR environment

Different approaches were explored to bring the project into a virtual reality environment. Unity’s official VR template was considered but discarded due to its complexity and focus on high-end devices (such as Oculus). The standard Android template was also discarded as it lacked VR integration. Ultimately, the Google Cardboard SDK template was chosen as the most optimal for the project's goals, being Android-focused and already prepared for basic VR visualization.

The official documentation and setup guide from Google were followed, though the installation process proved complex due to numerous configuration parameters.

The visualization evolved into 12 frequency channels arranged like a clock around the user’s camera, enabling a 360° immersive experience (without user movement). Each channel was connected to a particle spawner, similarly to how sliders were used in Experiment 2, but this time generating visual feedback in real-time.
Additionally, several parameters were exposed in the inspector: frequency amplification, particle emission rate, and a toggle to ignore background noise.

Conclusion: The Google Cardboard toolkit proved highly useful and will be used as the foundation for the application due to its Android-oriented approach and built-in VR capabilities. Issues were encountered when exporting skyboxes to Android, likely due to the use of 6-sided skyboxes and rendering settings specific to URP. Further investigation is needed.
The results of this experiment are promising: a satisfactory real-time visual response was achieved, although further tuning and development of a consistent visual identity are still needed.

