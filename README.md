# WarioConsoleApp

Jednoduchá konzolová aplikácia v C#, ktorá keď beží každú hodinu stiahne dáta z metostanice, pretransformuje ich na JSON formát a uloží ich do SQL databázy aj s časom kedy sa uložili.
Pokiaľ je meteostanica nedostupná, uloží sa prázdny záznam do SQL databázy s informáciou, že nebola dostupná.

## Spustenie
1. Nainštalujte si [.NET](https://dotnet.microsoft.com/en-us/download)
2. Nainštalujte si [GIT](https://git-scm.com/downloads/win)
3. Vytvorte priečinok, kde si chcete projekt stiahnúť a do cmd:
   ```
   git clone https://github.com/Ados-developer/WarioConsoleApp.git
   ```
4. Spustite aplikáciu:  
   - vo Visual Studiu: **Debug → Start Without Debugging (Ctrl + F5)**  
   - cez príkazový riadok: v priečinku, kde je .csproj súbor, spustite:
     ```
     dotnet run
     ```

## Databáza
Pre tento jednoduchý projekt som použil SQLite v súbore "WarioConsoleApp.db". Tento súbor sa automaticky vytvorí pri prvom spustení.

## Čas implementácie
Celkový projekt mi zabral približne 1,5 hodiny.
