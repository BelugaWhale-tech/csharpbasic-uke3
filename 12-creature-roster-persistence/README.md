# Oppgave 12 — Creature Roster Persistence

**Hovedfokus:** objekter til fildata og tilbake

Du skal lagre en `List<Creature>` i en enkel tekstfil og rekonstruere objektene senere.

Filformat:

```text
Name|Species|Energy
```

Eksempel:

```text
Mora|Lumen Fox|72
Kip|Dust Eel|18
```

Krav:
- Lag `ToFileLine()` på `Creature` **eller** en separat metode som konverterer objekt → string.
- Lag kode som kan parse en gyldig linje tilbake til et `Creature`.
- Bruk `int.TryParse` for Energy.
- Ugyldige linjer skal hoppes over, ikke krasje programmet.
- Programmet skal kunne skrive en liste til `creatures.txt`, lese filen og bygge en ny `List<Creature>`.

Hold formatet enkelt. Dette er en øvelse i dataflyten `object → text → file → text → object`, ikke i avansert serialisering.

## Kjøring

```bash
dotnet run
```
