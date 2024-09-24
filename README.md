Título: Eventos Personalizados
Propósito: Evaluar la comprensión de la herencia y la sobrecarga de métodos en
escenarios reales.
Descripción:
Se solicita crear una aplicación en C# Forms que permita gestionar los costos de diferentes
tipos de cenas: CenaCumpleaños y CenaGala. El sistema debe permitir ingresar los datos
necesarios para cada tipo de cena y calcular los costos basados en diferentes parámetros.
Reglas de negocio:
Regla 1: Número de Personas:
• El número de personas para cualquier cena no puede ser menor a 1 ni mayor a 500.
• Si el valor ingresado es menor a 1 o mayor a 500, el sistema debe mostrar
un error y rechazar la operación.

Regla 2: Decoración:
• Si la opción de decoración es seleccionada (Decora = true), se debe aplicar un costo
adicional basado en el número de personas.
• El costo de decoración será $15 por persona. Este valor debe multiplicarse por el
número total de personas y sumarse al costo total.
• Si no se selecciona la decoración, este valor debe permanecer en 0.
Regla 3: Costo de la Comida:
• El costo de la comida por persona (CostoComidaPorPersona) no puede ser menor
a $10 ni mayor a $500.
• Si el valor es menor o mayor a este rango, el sistema debe rechazar el valor
y notificar al usuario.

Regla 4: Bono Extra:
• El BonoExtra solo se podrá aplicar si el costo total de la cena supera los $1000.
• Si el costo total no llega a esta cantidad, el bono extra no se aplicará, y el
sistema deberá notificar al usuario.
Regla 5: Tamaño del Pastel en CenaCumpleaños:
• Para cenas de cumpleaños, el tamaño del pastel debe estar entre 1 y 5 (donde 1 es
pequeño y 5 es grande).
• Cualquier valor fuera de este rango debe ser rechazado, mostrando un
mensaje de error al usuario.

• El costo del pastel debe calcularse multiplicando el tamaño del pastel por $50.
Regla 6: Texto del Pastel en CenaCumpleaños:
• El texto del pastel debe tener un máximo de 30 caracteres.
• Si el texto ingresado excede este límite, el sistema debe notificar al usuario
y permitirle ingresar un texto más corto.

Regla 7: Opción Saludable en CenaGala:
• Para cenas de gala, si se selecciona la opción de comida saludable
(OpcionSaludable = true), se debe aplicar un costo adicional de $5 por persona.
• Esta opción solo está disponible si el costo promedio por persona es mayor a $50.
Si es menor, la opción no puede ser seleccionada, y el sistema debe desactivarla
automáticamente.
Regla 8: Costo de Decoración en CenaGala:
• El costo de decoración en una cena de gala debe calcularse en función del estilo
del evento, agregando un costo base de $500 si el número de invitados supera los
100.
• Si el número de invitados es menor a 100, no se aplica este costo adicional.
Regla 9: Validación de Costos Totales:
• El costo total de la cena no debe ser negativo. Si algún cálculo genera un valor
negativo, el sistema debe alertar al usuario y detener la operación.
• El costo total mínimo para cualquier cena debe ser de al menos $100. Si el costo es
menor a este valor, se debe notificar al usuario y no permitir la confirmación de la
cena.

Requisitos Funcionales:

1. Ventana Principal:
• La ventana principal debe permitir seleccionar entre organizar una Cena de
Cumpleaños o una Cena de Gala.
• Dependiendo de la selección, se debe mostrar un formulario con los campos
correspondientes a cada tipo de cena.

2. Clase Base: Cena:
• La clase Cena tendrá los siguientes atributos:
▪ NumeroDePersonas: Número total de personas que asistirán al
evento.
▪ CostoDecoracion: Costo base de la decoración. Inicialmente será 0,
pero si se selecciona la opción de decoración, el costo aumentará.
▪ BonoExtra: Un bono opcional que se sumará al costo total.
▪ CostoComidaPorPersona: Costo por cada persona basado en el
menú seleccionado.
▪ Decora: Un valor booleano que indica si habrá decoración o no.
• Métodos:
▪ CalcularCostoDeDecoracion: Si se selecciona la opción de
decoración, este método calculará el costo adicional de acuerdo con
el número de personas.
▪ CalcularCosto: Este método calculará el costo total de la cena,
incluyendo comida, decoración y otros bonos.

3. Clase Derivada: CenaCumpleaños:
• Atributos adicionales:
▪ TamanoPastel: Tamaño del pastel para la fiesta de cumpleaños.
▪ TextoPastel: Texto que se incluirá en el pastel.
• Métodos:
▪ CalcularCostoDeDecoracion: Sobreescribe el método base y calcula
un costo adicional para la decoración basada en el pastel y el número
de invitados.
▪ CalcularCosto: Este método calculará el costo total de la cena de
cumpleaños, incluyendo el pastel y otros elementos adicionales.

4. Clase Derivada: CenaGala:
• Atributos adicionales:
▪ CostoPromedioPorPersona: Costo de la comida por persona, que
puede ser diferente al de la cena de cumpleaños.
▪ OpcionSaludable: Un valor booleano que indica si se incluirán
opciones de comida saludable.

• Métodos:
▪ CalcularCostoDeDecoracion: Calcula el costo de la decoración
dependiendo del estilo de la gala.
▪ CalcularCosto: Este método calculará el costo total de la cena de
gala.
▪ SetOpcionalSaludable: Método que permite establecer si se ofrecen
opciones de comida saludable, lo que puede afectar el costo final.

Funcionalidades del Formulario:
• Formulario para CenaCumpleaños:
• Ingreso del número de personas.
• Ingreso del tamaño del pastel y el texto del pastel.
• Ingreso del costo por persona.
• Opción para agregar decoración.
• Botón para calcular el costo total de la cena de cumpleaños.
• Formulario para CenaGala:
• Ingreso del número de personas.
• Ingreso del costo por persona.
• Opción para elegir si se desea decoración.
• Opción para elegir si se desea un menú saludable.
• Botón para calcular el costo total de la cena de gala.

Requisitos Técnicos:
• Utilizar herencia para implementar la relación entre las clases.
• Implementar los métodos correspondientes para el cálculo de costos de decoración
y costos totales.
• La interfaz gráfica debe estar diseñada en C# Forms, y los valores ingresados deben
afectar el cálculo de costos de manera dinámica.
Extras:
• Agregar un campo para mostrar el costo total en ambas ventanas.
• Manejo de errores para asegurarse de que todos los campos requeridos sean
ingresados correctamente antes de calcular el costo con try-catch.
• Aplicar buenas prácticas – nomenclatura
