<div align="center">
  <img src="./pslib-logo.webp" width="86" height="45">
  <h3 align="center">Projekt pro porovnávání efektivity řadících algoritmů</h3>

  Bohuslav Čermák, Vít Dobrovský
  
  <p align="center">
    <br />
    <a href="https://github.com/pslib-cz/2024-p2a-prg-sortingcomparsion-cermakdobrochlap/blob/main/%C4%8Cerm%C3%A1k-Dobrovsk%C3%BD_Ro%C4%8Dn%C3%ADkov%C3%BD%20projekt%20-%20porovn%C3%A1n%C3%AD%20%C5%99ad%C3%ADc%C3%ADch%20algoritm%C5%AF.docx"><strong>Projektový dokument</strong></a>
    &middot;
    <a href="https://pslib.sharepoint.com/sites/studium/prg/SitePages/CSharp-Project-SortingEffectivity.aspx">Zadaní projektu</a>
  </p>
</div>

<br />

## O projektu
Práce se zaměřuje na analýzu a porovnání dvou řadících algoritmů – Bublinkového řazení (Bubble Sort) a Rychlého řazení (Quick Sort). Cílem je zhodnotit jejich efektivitu vzhledem k velikosti a typu datových sad, s důrazem na časovou složitost a paměťovou náročnost.

Vychází z teoretických principů třídění, přičemž Bublinkové řazení je jednoduché, ale neefektivní u větších datových sad, zatímco Rychlé řazení je efektivnější díky metodě dělení dat.

Práce přináší výsledky testování na různých datových sadách, které ukazují rozdíly v výkonu obou algoritmů. Tyto výsledky pomohou při výběru vhodného algoritmu podle konkrétních potřeb.

<br />

## Použité řadící algoritmy
### Bublinkové řazení (Bubble Sort)
Bublinkové řazení funguje tak, že prochází seznam a porovnává sousední prvky. Pokud jsou v nesprávném pořadí, vymění se. Tento proces se opakuje, dokud není seznam seřazený.

#### Charakteristiky - teoretické
Parametr      | Popis
------------- | -------------
Časová složitost  | O(n²) (průměr a nejhorší výsledek), O(n) (nejlepší výsledek)
Paměťová náročnost  | O(1) – konstantní množství paměti
Stabilita  | Ano – zachovává pořadí stejné hodnoty
Rychlost  | Pomalé pro velké datové sady
Jednoduchost implementace  | Velmi jednoduché
Použití | Vhodné pro malé datové sady

<br />

### Rychlé řazení (Quick Sort)
Rychlé řazení funguje na principu "rozděl a panuj". Nejprve se vybere pivot, prvek, který rozdělí seznam na dvě části. Jedna část obsahuje prvky menší než pivot, druhá větší. Tento proces se opakuje rekurzivně pro každou část, dokud nejsou všechny části seřazeny.

#### Charakteristiky - teoretické
Parametr      | Popis
------------- | -------------
Časová složitost  | O(n log n) (průměrný a nejlepší výsledek), O(n²) (nejhorší výsledek)
Paměťová náročnost  | O(log n) – požaduje stack pro rekurzi
Stabilita  | Ne – nezachovává pořadí stejné hodnoty
Rychlost  | Rychlost	Relativně složitější než Bubble Sort
Jednoduchost implementace  | Vhodné pro velké datové sady
Použití | Vhodné pro malé datové sady

<br />

## Výběr datových sad
Testovali jsme řadící algoritmy na sadách dat různých velikostí a porovnávali jejich výkon. Vybrali jsme tyto datové sady:

| Typ                | Počet dat  |
|--------------------|------------|
| Náhodná drobná     | 10         |
| Srovnaná drobná    | 10         |
| Náhodná malá       | 100        |
| Srovnaná malá      | 100        |
| Náhodná střední    | 1000       |
| Srovnaná střední   | 1000       |
| Náhodná velká      | 10000      |
| Srovnaná velká     | 10000      |
| Náhodná velmi velká| 100000    |
| Srovnaná velmi velká| 100000   |
| Náhodná gigantická | 1000000   |
| Srovnaná gigantická| 1000000   |