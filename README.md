# Just.Net
Client .Net pentru portal.just.ro

[![NuGet](https://img.shields.io/nuget/v/Just.Ro.Portal.Net.svg?style=flat-square)](https://www.nuget.org/packages/Just.Ro.Portal.Net)

Documentatie ANAF: https://portal.just.ro/SitePages/acces.aspx

http://portal.just.ro/SitePages/circumscriptii.aspx

[Documentarea serviciului web de conectare programatică la date şi export.doc](https://portal.just.ro/SiteAssets/SitePages/acces/Documentarea%20serviciului%20web%20de%20conectare%20programatic%C4%83%20la%20date%20%C5%9Fi%20export.doc)

![logo](antet_site_iulie_2019.jpg)

Serviciul web portal.just.ro permite accesul la datele despre dosare, părţi şi şedinţe de judecată.
Adresa serviciului web este: http://portalquery.just.ro/query.asmx

    Serviciul web permite accesul la date folosind două metode de interogare:
    - căutare dosare
    - căutare şedinţe

 
Căutarea dosarelor
 
Căutarea dosarelor se face dupa următorii parametri de interogare:
- număr dosar
- obiect dosar
- nume parte
- instanţă
- perioadă (dosare dintr-un interval de timp)
 
La o interogare se pot folosi combinaţii de parametri. Se va completa obligatoriu cel puţiu unul din parametrii: număr dosar, obiect dosar, nume parte.
Notă: lista rezultată la o interogare va conţine maxim 1000 dosare.
 
Informaţiile obţinute sunt:
- numărul dosarului (format numar unic)
- număr în format vechi (dacă există)
- data dosarului
- instanţa dosarului
- departamentul (secţia)
- categoria cazului
- stadiul procesual al dosarului
- lista de parţi din dosar
- lista de termene ale dosarului
- lista de căi de atac

Căutarea şedinţelor
 
Căutarea şedinţelor se face dupa următorii parametri de interogare:
- data şedinţă (obligatoriu)
- instanţa (obligatoriu)
 
Informaţiile obţinute sunt:
- departamentul (secţia)
- numele completului de judectă
- data şedinţei
- ora şedinţei
- lista de dosare din şedinţă

