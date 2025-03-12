## CASO: 

Imagina que tienes varios electrodomésticos en casa (nevera, televisor, microondas, etc.), 
y necesitas administrar su consumo de energía y generar un informe sobre su estado.

Este código original hace todo en una sola clase(HomeApplianceManager), lo cual viola SRP
y Information Expert porque una sola clase maneja electrodomésticos, calcula el consumo total y genera informes


## RETO: 
Refactorizar el codigo implementando el principio de responsabilidad unica y el patro information expert. 
