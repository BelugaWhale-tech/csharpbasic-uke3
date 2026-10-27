# Week 3 — Klasser, Objekter and Persistens

Denne uken flyttes fokus fra løse variabler og metoder til objekter som representerer data og oppførsel. Mot slutten serialiserer vi enkle objekter til en tekstfil og rekonstruerer dem ved programstart.

## Oppgaver

01. **Transmission Printer I** — method overloads
02. **Transmission Printer II** — overloads med ny signatur
03. **Unknown Creature** — første klasse og objekter
04. **Moon Parcel** — constructor + properties
05. **Maintenance Drone** — instance methods
06. **Beacon Network** — static vs instance members
07. **Label Generator** — public og private members
08. **Move the Model** — klasse i egen fil
09. **Artifact Shelf** — List<T> med objekter
10. **Catalog vs Catalog Operations** — separere datarepresentasjon fra operasjoner
11. **Black Box Recorder** — synkron filskriving/-lesing og File.Exists
12. **Creature Roster Persistence** — objekter til fildata og tilbake

Hver oppgave er et selvstendig .NET 10 console-prosjekt. En feil i én oppgave påvirker ikke de andre.

## Bruk av KI

Du kan gjerne bruke KI-verktøy som er integrert i kodeeditoren din dersom du trenger hjelp til å komme i gang, forstå en feilmelding eller står fast underveis.

I hver oppgave ligger det en `AGENTS.md`-fil med instruksjoner til KI-verktøyet. Hensikten er at KI-en skal fungere som en veileder: den kan hjelpe deg med å forstå problemet, stille spørsmål, forklare konsepter og gi hint, men skal ikke løse oppgaven for deg eller skrive ferdig løsningen.

Målet er at du selv skal få øvd på programmeringen og forstå hvorfor løsningen fungerer.

# Kjøre oppgavene

Hver oppgave i dette oppgavesettet er et eget lite .NET-prosjekt. Du trenger derfor **ikke å gå inn i oppgavemappen med `cd` hver gang du vil kjøre en oppgave**.

## 1. Åpne terminalen i VS Code

I VS Code kan du åpne den innebygde terminalen via:

**Terminal → New Terminal**

Pass på at terminalen står i mappen for denne uken. Hvis du for eksempel jobber med uke 1, bør du være i:

```text
week-01-decisions-and-repetition
```

Når du står her, kan du kjøre hvilken som helst av oppgavene direkte.

---

## 2. Kjør en bestemt oppgave

For å kjøre oppgave 1:

```bash
dotnet run --project 01-mission-badge
```

For å kjøre oppgave 2:

```bash
dotnet run --project 02-cargo-scanner
```

Og tilsvarende for de andre oppgavene:

```bash
dotnet run --project 03-reactor-window
```

Du trenger altså ikke gjøre dette:

```bash
cd 01-mission-badge
dotnet run
cd ..
cd 02-cargo-scanner
dotnet run
```

Det holder å bli stående i ukesmappen og bruke `--project` for å velge hvilken oppgave du vil kjøre.

---

## 3. Bruk `Tab` i stedet for å skrive hele mappenavnet

Du trenger ikke huske eller skrive hele navnet på oppgavemappen.

Begynn for eksempel å skrive:

```bash
dotnet run --project 01
```

og trykk deretter **Tab**.

Terminalen kan da automatisk fullføre mappenavnet:

```bash
dotnet run --project 01-mission-badge
```

Dette kalles **tab completion**, og er en nyttig vane når du arbeider i terminalen.

Du kan også skrive noen flere tegn dersom flere mapper begynner likt, og deretter trykke `Tab` igjen.

---

## 4. Bruk pil opp for å hente tidligere kommandoer

Terminalen husker kommandoene du nettopp har brukt.

Trykk **↑ (pil opp)** for å hente frem forrige kommando.

Hvis du nettopp kjørte:

```bash
dotnet run --project 01-mission-badge
```

kan du trykke pil opp og bare endre `01-mission-badge` til neste oppgave, i stedet for å skrive hele kommandoen på nytt.

Kombinert med `Tab` gjør dette det raskt å bytte mellom oppgavene.

---

## 5. Stoppe et program

Noen oppgaver inneholder programmer som fortsetter å kjøre, for eksempel en `while`-løkke som venter på input.

Hvis du trenger å stoppe programmet manuelt, bruk:

```text
Ctrl + C
```

Dette avslutter programmet som kjører i terminalen.

---

## 6. Hvis terminalen er full av tekst

Du kan rydde terminalvinduet uten å lukke det.

I VS Code fungerer vanligvis:

```text
Ctrl + L
```

Du kan også bruke:

```bash
clear
```

på macOS/Linux, eller:

```powershell
cls
```

i PowerShell på Windows.

Dette påvirker ikke programmet eller filene dine. Det rydder bare det som vises i terminalen.

---

## Hvis `dotnet run --project ...` ikke finner prosjektet

Hvis du får en feilmelding om at prosjektet eller prosjektfilen ikke finnes, kontroller først at terminalen står i riktig **ukemappe**.

Du kan se hvilken mappe terminalen står i ved å se på teksten foran markøren i terminalen.

Et eksempel på riktig struktur for uke 1 er:

```text
week-01-decisions-and-repetition
├── 01-mission-badge
├── 02-cargo-scanner
├── 03-reactor-window
├── 04-crystal-classifier
└── ...
```

Hvis terminalen står i `week-01-decisions-and-repetition`, skal denne kommandoen fungere:

```bash
dotnet run --project 01-mission-badge
```

---

## Et godt arbeidsmønster

Når du arbeider med oppgavene kan du for eksempel gjøre dette:

1. Åpne `Program.cs` i oppgaven du jobber med.
2. Les hele oppgaveteksten før du begynner å kode.
3. Skriv litt kode.
4. Lagre filen.
5. Kjør oppgaven fra terminalen med `dotnet run --project ...`.
6. Les resultatet eller feilmeldingen nøye.
7. Gjør en liten endring og kjør programmet på nytt.

Eksempel:

```bash
dotnet run --project 01-mission-badge
dotnet run --project 02-cargo-scanner
dotnet run --project 03-reactor-window
```

Du blir stående i samme terminalmappe hele tiden og velger prosjekt med `--project`.
