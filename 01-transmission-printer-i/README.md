# Oppgave 01 — Transmission Printer I

**Hovedfokus:** method overloads

Lag to metoder med samme navn:

```csharp
PrintTransmission(string message)
PrintTransmission(string sender, string message)
```

Første overload skal skrive:
`[UNKNOWN] message`

Andre skal skrive:
`[sender] message`

Kall begge variantene. Observer at C# velger riktig metode basert på argumentlisten.

## Kjøring

```bash
dotnet run
```
