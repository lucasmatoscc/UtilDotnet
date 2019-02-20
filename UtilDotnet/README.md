# Funcionalidades

 Para utilizar é só importar a dll no projeto:
 ``` C#
 import 'package:util_data_table_package/utilDataTable.dart';
 ```

Enviar e-mail:

``` C#
EnviarEmail email = EnviarEmail(usernameEmail,passwordEmail);
email.enviarEmail(string to, List<string> ccs, string titulo, string descEmail, byte[] bytes)
 ```
 
