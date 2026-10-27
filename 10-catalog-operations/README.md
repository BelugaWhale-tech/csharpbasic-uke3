# Oppgave 10 — Catalog vs Catalog Operations

**Hovedfokus:** separere datarepresentasjon fra operasjoner

Målet er å skille **datarepresentasjon** fra **operasjoner på data**.

`Artifact` skal være en enkel modell. `ArtifactCatalog` skal inneholde operasjoner som:
- `Add(Artifact artifact)`
- `PrintAll()`
- `FindByName(string name)` som returnerer et `Artifact?`

Ikke legg konsollmeny eller filhåndtering inn i `Artifact`-klassen.

Bruk løkker, ikke LINQ; LINQ kommer neste uke.

## Kjøring

```bash
dotnet run
```
