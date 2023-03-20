# CosmosDB
## Las bases de datos NoSQL se han diseñado para abordar estas necesidades y desafíos únicos, como los siguientes:

- Grandes volúmenes de datos
- Datos con muchos orígenes y formatos diferentes
- Esquemas de datos dinámicos para almacenar diferentes tipos de datos

## Uso de datos de alta velocidad o en tiempo real

- Características
- No Relacional
- Escalado horizontal
- Sin esquema

## Casos de uso comunes para Azure Cosmos DB for NoSQL
- IoT y telemetría
- Venta minorista y marketing
- Web y dispositivos móviles
- Escenario de módulo

### Evaluación de los requisitos de rendimiento


> La medición de RU/s para las consultas debe realizarse a escala. La medición de las consultas que se ejecutan en una sola partición física no dará lugar a datos significativos sobre el verdadero rendimiento usado en el escenario real una vez implementado y escalado horizontalmente 

### Periodo de vida TTL

Azure Cosmos DB permite establecer el período de vida de los documentos en la base de datos antes de su purga automática. El período de vida (TTL) de un documento se mide en segundos desde la última modificación y se puede establecer en el nivel de contenedor con la capacidad de invalidación por elemento.

Una vez establecido en el nivel de contenedor, Azure Cosmos DB purgará automáticamente los documentos en el momento especificado desde que se modificaron por última vez. El valor de TTL se define como un entero en segundos.

El valor de TTL de un elemento se configura estableciendo la ruta de acceso ttl del elemento. El valor de TTL de un elemento solo funcionará si la propiedad **DefaultTimeToLive** está configurada para el contenedor principal. Si la ruta de acceso ttl está configurada para el elemento, invalidará la propiedad **DefaultTimeToLive** del contenedor principal.
