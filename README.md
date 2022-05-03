# 26 de Abril


Encapsulamiento

Consiste en almacenar  y organizar en una clase, las características y funcionalidades de los objetos, representando las por medio de atributos y métodos.
Todo esto se genera gracias a la abstracción.

Gracias al encapsulamientos podemos asegurar que los datos sean correctos y completos y además evita el acceso de datos por otro medio que sea distinto al que indiquemos.

Gracias a eso podemos controlarlo gracias a los modificadores de acceso:

básicamente nos permiten generar un nivel de seguridad mayor en nuestras clases.

Público:todos tienen permiso para modificar.
Protected: acceso a elementos de la misma clase o paquetes.
Private: sólo puede ser accedido por los métodos o constructores de la misma clase.

Abstracción

Es un proceso por lo cual se descarta aquella información que no resulta relevante en un contexto actual, depende principalmente el criterio del observador (programador),la abstracción y la capacidad de captar las distintos atributos y métodos que se van a utilizar en el juego.
Al definir una clase podemos declarar que esta es abstracta. Una clase abstracta no puede ser instanciada, sirve para hacer de tipo base para otras clases. Sin embargo, puede tener constructores declarados con el mismo propósito. 

Herencia

La herencia permite establecer una estructura de clases organizada en jerarquías.
En las clases superiores (conocidas como super clases) se definen las propiedades y el comportamiento más general y se crean clases hijas (subclases) que heredan las propiedades y el comportamiento de la superclase.
A través de la herencia se pueden construir clases cada vez más específicas pero que tienen características en común entre ellas ya que descienden de la misma superclase.

Polimorfismo

El polimorfismo nos permite tomar un conjunto de objetos de distinto tipo y ejecutar uno o más métodos que todos ellos entienden, pero la función que ejecute ese método será propia de cada tipo de objeto.
Esto nos permite crear distintos tipos de objetos que respondan de manera distinta a un mismo estímulo.
