# Arcade Tester 
### Programa en C# para la detección de entradas de controles arcade

## Descripción del proyecto
Proyecto realizado en C# con ayuda de la biblioteca SharpDX para detectar las entradas de un control arcade. El programa procesa los datos enviados por el control y los filtra para mostrar en pantalla el botón que estás pulsando en el momento.

## Instalación
1. Clona este repositorio:
    ```bash
    git clone https://github.com/usuario/arcade-tester.git
    ```
2. Instala las dependencias necesarias:
    - Asegúrate de tener instalado .NET Core o .NET Framework (según la versión que uses).
    - Incluye la librería SharpDX:
    ```bash
    Install-Package SharpDX
    ```

3. Ejecuta el proyecto en tu entorno de desarrollo (Visual Studio, JetBrains Rider, etc.).

## Uso
Este programa puede ayudar cuando se arma un control estilo arcade debido a que las tarjetas Raspberry Pi Pico (usadas comúnmente en estos ensambles) utilizan un firmware muy similar al de otros controles como los de PS3 y XBOX 360. El programa te permite comprobar si todos los botones están funcionando correctamente.

### Ejemplo:
Al presionar el botón correspondiente a la  'A' en tu control arcade, se mostrará en pantalla la indicación de que el botón está funcionando correctamente.

## Imágenes del programa 
[![Arcade-Tester-display.png](https://i.postimg.cc/6psD4R0p/Arcade-Tester-display.png)](https://postimg.cc/KRN9d1w6)

[![Ejecucion-Arcade.jpg](https://i.postimg.cc/3xKFqxrZ/Ejecucion-Arcade.jpg)](https://postimg.cc/0bBSMxw6)

## Imágenes del control arcade
[![Foto-Proyecto3.jpg](https://i.postimg.cc/9Mqd941c/Foto-Proyecto3.jpg)](https://postimg.cc/k6qR3gkH)

[![Foto-Proyecto.jpg](https://i.postimg.cc/ncx4shmt/Foto-Proyecto.jpg)](https://postimg.cc/14Wn2PMW)

## Tecnologías Utilizadas
- C# .NET
- Librería SharpDX

## Licencia
Este proyecto está licenciado bajo la licencia MIT. Consulta el archivo [LICENSE](LICENSE) para más detalles.
