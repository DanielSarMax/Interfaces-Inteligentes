# Proyecto de Escena 3D en Unity

![Gif1](./sample.gif)

## Descripción del trabajo realizado

El proyecto consiste en la creación de una escena 3D básica utilizando exclusivamente el editor de escenas de Unity. El objetivo es configurar una escena con diferentes objetos 3D, un terreno, prefabs del paquete **Starter Assets** y un objeto adicional descargado desde la **Asset Store**. Además, se incluye un script personalizado que imprime en la consola la posición de cada uno de los objetos de la escena.

### Estructura y configuración de la escena

1. **Incluir objetos 3D básicos:**
   - Se añadieron varios objetos 3D como cubos, esferas y cilindros a la escena.
   
2. **Paquete Starter Assets:**
   - El proyecto incluye el paquete **Starter Assets** para utilizar prefabs y configuraciones predefinidas para la cámara y el control del personaje.
   
3. **Objeto de la Asset Store:**
   - Se descargó e incluyó un objeto adicional desde la **Asset Store** que no forma parte de los Starter Assets llamado **Food Props**, este paquete nos permite introducir a la escena una variedad de frutas.
   
4. **Creación de un terreno:**
   - Se creó un terreno utilizando el editor de terrenos de Unity, dándole forma y textura básica.
   
5. **Etiquetas de objetos:**
   - Cada objeto en la escena cuenta con una etiqueta que permite su identificación única en el proyecto. Esto facilita la manipulación de los objetos a nivel de código.
   
6. **Uso de prefabs:**
   - Se utilizaron prefabs tanto de **Starter Asset FPS** como de **Third Person** para añadir personajes y elementos interactivos a la escena.

7. **Script para la consola:**
   - Se creó un script personalizado en C# que utiliza la clase `Transform` para obtener y escribir en la consola las posiciones de los objetos en la escena. La propiedad `Transform.position` permite acceder a la posición en el espacio 3D de cada objeto

![Ejecucion](sample2.gif)
