# Oppgave 06 — Beacon Network

**Hovedfokus:** static vs instance members

Hver beacon har sin egen frekvens, men systemet skal også vite hvor mange beacon-objekter som totalt har blitt konstruert.

Krav:
- `Frequency` skal være instance-data.
- `CreatedCount` skal være `static`.
- Constructoren skal øke `CreatedCount`.
- Opprett tre objekter og skriv både deres individuelle frekvenser og den delte counten.

Diskuter gjerne: hvorfor ville `Frequency` vært feil som `static`?

## Kjøring

```bash
dotnet run
```
