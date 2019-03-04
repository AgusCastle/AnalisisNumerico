# Análisis Numérico
Repositorio con programas de análisis numérico.

## Comenzando
* _Para contribuir realice las siguientes instrucciones:_
	1. Hacer fork en el repositorio de github

	2. Hacer git clone:
		`git clone https://github.com/tu_username/AnalisisNumerico.git`

	3. Comprobar la url:
		`git remote -v`

	4. Antes de realizar modificaciones agregar la URL del repositorio original del proyecto:
		`git remote add upstream https://github.com/leosykes117/AnalisisNumerico.git`

	5. Comprobar:
		`git remote -v`

	6. Actualizar master:
		`git pull -r upstream master`

	7. Crear tu rama:
		`git checkout -b feature-nombre-rama`

	8. Realizar todos los cambios que se desea hacer al proyecto.

	9. Agregar los archivos y hacer un commit.

	10. Después de realizar el commit hacer el push hacia nuestro repositorio indicando la rama que hemos creado:
		`git push origin feature-nombre-rama`

	11. Hacer click en "Compare & Pull Request"

	12. Escribir cambios del Pull Request.

	13. Si todo está bien, enviar con el botón "Send Pull Request".
* Al crear un archivo:
	1. Si se guardara en la carpeta **CodigosBase**, nombrar el archivo con el método  usado (con sintaxis camel case). Ejemplo:
		* newton_rapson.cpp
		* gauss_jordan.py
		* biseccion.java

	2. Si el archivo es guardado en la carpeta **Ejercicios**, colocar el archivo en la carpeta correspondiente al lenguaje en el que fue programado; nombrar el archivo con la palabra "_practica_" seguida de el número que corresponde y el nombre del método usado (con sintaxis camel case). Ejemplo:
		* practica1_biseccion.py
		*	practica2_newton_rapson.cpp
		*	practica3_newtonrapson.java
		*
* Dejar un mensaje en el commit, decir detalladamente que cuales fueron los cambios que se hicieron en el repositorio, esto es con el fin de llevar un mejor control en las versiones del proyecto. Ejemplo:
	`git commit -m "Se agrego el archivo gauss_jordan.py en la carpeta CodigosBase; Se modifico el metodo derivar() en el archivo newton_rapson.cpp dentro de la carpeta CodigosBase"`
