# Oppgave 11 — Black Box Recorder

**Hovedfokus:** synkron filskriving/-lesing og File.Exists

Lag en liten black box-recorder med synkron filbehandling.

Krav:
1. Hvis `blackbox.txt` **ikke finnes**, skriv tre eksempel-linjer til filen.
2. Bruk `File.Exists(...)` før du bestemmer hva som skal skje.
3. Les deretter alle linjene fra filen og skriv dem til terminalen.
4. Kjør programmet to ganger og observer forskjellen mellom første og andre kjøring.

Bruk enkle synkrone metoder fra `System.IO`, for eksempel `File.WriteAllLines` og `File.ReadAllLines`.

## Kjøring

```bash
dotnet run
```
