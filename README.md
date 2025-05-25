[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

1. ¿String es un tipo por valor o un tipo por referencia?
R: String es un tipo por referencia, pero se comporta como inmutable. Cada vez que se modifica una cadena, se crea un nuevo objeto en memoria.

2. ¿Qué secuencias de escape tiene el tipo string?
R: Las secuencias de escape más comunes en C# para strings son:
   - \n : salto de línea
   - \t : tabulación
   - \\ : barra invertida
   - \" : comillas dobles
   - \' : comilla simple
   - \r : retorno de carro
   - \b : retroceso
   - \f : salto de página
   - \0 : carácter nulo

3. ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
R:
   - @ antes de una cadena permite escribir texto literal, ignorando secuencias de escape. Ejemplo: @"C:\Archivos\MiTexto.txt"
   - $ permite interpolación de variables dentro de la cadena. Ejemplo: $"Hola {nombre}"
   - Se pueden combinar: $@"Hola {nombre}\n" interpreta variables pero ignora secuencias de escape como \n.
