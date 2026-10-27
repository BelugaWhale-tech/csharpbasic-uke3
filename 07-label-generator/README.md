# Oppgave 07 — Label Generator

**Hovedfokus:** public og private members

`LabelGenerator` skal tilby én offentlig operasjon til resten av programmet, men bruke en privat hjelpeoperasjon internt.

Krav:
- `CreateLabel(...)` er `public`.
- En hjelpefunksjon som normaliserer teksten skal være `private`.
- `Program.cs` skal kunne kalle `CreateLabel`, men ikke den private metoden.

Prøv gjerne å kalle den private metoden fra `Program.cs`, observer compiler-feilen, og fjern så forsøket igjen.

## Kjøring

```bash
dotnet run
```
