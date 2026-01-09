# TSEP como usar

## Importante - Criar soluções sem espaços no nome

## 1. Editar /TsepInstaller/TsepDefinitions.xml

Product -> ID, Name, Description, UpgradeCode
Component -> Guid

## 2. binaries

Colar o .exe da aplicação e editar o XML
 - Trocar o nome do arquivo para corresponder ao exe. (App_ComponentCatalog.ac.XML)
 - No XML:
   - Display Name
   - MacroFileName

## 3. Macros

Editar o .cs para corresponder com o MacroFileName alterado acima
Renomear o .png com o mesmo nome

## 4. Usar o TeklaExtensionPackage.Builder