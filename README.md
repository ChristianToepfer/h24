# h24

## Aufbau

* Server ohne Auslesen, nur für Netzwerkausfall im Ziel.

## Installation

### Datenbank



## Einweisung

Alle Änderungen sind direkte Datenbankänderungen, kein extra Abfragebox oder Bestätigung!

* SI-Chip Änderung direkt im Hauptfenster
  * Unbekannt Chip-Nummer nach dem Auslese, wird abgefragt, wird aber nicht automatisch in die Datenbank übernommen
  * TODO: Abfrage, den SI-Chip zu übernehmen hinzufügen?

* TODO: Teamname Änderung direkt im Hauptfenster? Könnte man dort auch verriegel, wenn es im Meldungsfenster geht?
* TODO: Läufennamen Ändern direkt im Hauptfenter? Könnte man dort auch verriegel, wenn es im Meldungsfenster geht?
* TODO: Läuferreihenfolge mit Pfeiltasten hoch und runter ( zur eigenen Sicherheit, nur Meldungsfenster!)
* TODO: Jahrgangs Anzeige und Änderung nur im Meldungsfenster

* TODO: Splittime Fester - Anzeige per click auf die Auslese-Zeil in der Tabelle

* **Bahnzuordnung erfolgt automatsch muss aber kontrolliert werden**
   * Läufer ist zum Beispiel einen andern Läufer vollständig angelaufen, dann hat er automatisch ein gültige Bahnzuordnung
     aber nicht sein!
* FIXME: **SI-Chip nur einmal pro Lauf auslesen!**

## Daten-Import

### Meldungen

* CSV-Datei
  * Manuelle Startnummern Vorgabe ist dort viel einfacher möglich 
* CSV Speichern und Encoding nach UTF8 with BOM Konvertieren (mit VS code)
  * "with BOM" damit die Datei mit Excelt erneut richtig geöffnet werden kann
  * ohne BOM wird CSV-Datei mit Ansi kodiierung geöffnet
* Import
  * Spalten werden über den Name angesprochen
  * weitere Spalten oder Spaltenreinfolge ist egal

### Bahndaten

* OCAD 8 Export


## Anzeige

### Courses Info vs. Import

  * Welche Bahnen gelaufen sind gehört in Hauptfenster +  Anzahl der Wechsel
  * File / Print Open Courses... (Wenn offene Bahnen direkt im Hauptfenster angezeigt werden verwirrt das zu sehr!)
    * Drucken Vorschauen:.. startnummer Eingabe, nächste Startnummern Butten. Print All von bis
    * ... nächte Startnumemrauswhl.. Filter kathorgie, Print, Print All
    (Anzeige welche Bahnen ein Team schon gelaufen ist)
    * Anzeige welche Bahnen ein Team noch nicht gelaufen ist
      * Überschrift: "Open Courses"  + Kathegorie
      * Team-Nr, Team-Name
      * alle Bahnen untereinander, so kann man was dainter vermerken oder abhanken.
        * Gruppung nach Day, Night, Final
      * Anzahl:
      * Druckzeitpunkt
      (könnte man zur Not auch json Ausgeben)
      
   * welche aktuell möglich sind (für eine Vorstart-Lösung) 
        * Kartenausgaben am Sonntag, nach Zielschluss: Team x Bahn Matrix.. Restbahnen pro Team oder Bahnen mit Teamnummern (ausdruck)


  *  TODO: Prüfen, ob mehrfach gelaufe Bahnen nur einmal gezählt werden. 


## TODO
* Windows XP Nutzbar?
* geht es auch ohne ODBC?

* TODO: Rename: "Courses" in "Import Courses..."
* TODO: Überall wo ein neues Fenster aufgeht "..." ergänzen.

* TODO: Hauptanzeige: die automatisch zugeordnete Bahn anzeigen

* TODO: Startbahn-Zuorder, über eine Vorauswahl oder Nachprüfung und neu Zuordnung wie "Change Course"
        * aktuelle Bahnzuordnung pro Team
        * für eine Vorstartlösung: noch eine nächste Bahnzuorndung, die dann automatisch zur akuellen wird

* TODO: ExportWinnerList aus Datenbank füllen (2023 als test exporieren)

* Datenbank Diagramm erstellen, ausdrucken

* FIXME: Teamnamen nicht änderbar, von der Oberfläche!
* FIXME: Jahrgang beim Team mit Anzeigen unänderbar

* TODO: Buttons umbennen, was sie machen
   * "Change Course"
   * "Recalculate"

* Readout-List 
  * Spiltime mit Click anzeigen, nicht erst mit Button
  * Filter/Option:
    * alle (wie aktuell)
    * nur die Bahnen vom gerade ausgelesen Team 
    * nur die am akuellen Rechner ausgelesen (nach neustart des Programms) -> default
* TODO: Läufer mit neuem Si-Chip. Abfragebox einfügen, diese gleich in der Datenbank zu übernehmen?


* Teamverwaltung
  * delete Button, um einzelne Teams wieder zu entfernen
  * weiterer Import oder doch direkt Teams hinzufügen in der Oberfläche 
  * Läufenreinfolge mit Button ändern, nicht mit order und Startnummern Anpassung!

* TODO: Finish-Auslesen optimeriern: 40 sekunden (einstellbar) nach letztem stempel.

* TODO: Prüfen, nach 9 Uhr bzw. nach seiner Zielzeit (6h,12h, strafzeiten) eingelaufen, wird automatisch disqualifiziert.
* TODO: Jahrgangsprüfung schon umgesetzt? Wie wird ein Verstoß dann angezeigt?
* TODO: 2 Frauen Prüfung bei 24-Team umgesetzt? Wie wird der Verstoß dann angezeigt?
* TODO: Prüfung ausgefallen Läufer
* TODO: Prüfung der Läuferreinfolge, was passiert, wenn es nicht passt, was wird angezeigt?
* TODO: Prüfung, Bahnfreigabe zum laufen. Dämmerungsbahn.. Nachtbahnen erst nach Dämmerungsbahnen...finalbahn erstnach allen Tag/Nacht bahnen.

* Möglichkeit zum Bahn bwz. Strecke rausnehmen

## Merge zur Hauptversion
* TODO: finish_missing über get_config_item bereitstellen?
* TODO: Import-Möglichkeiten


## SQL Export
 * advance -> "Schema and Data"

## GibHub unterschiede:
 * app.config: koe + andere Einstellung die gar nicht gebraucht werden?
 * h24.csproj: nur settings die automatsisch korrigiert werden.
 * Properties\Settings.settings: extra sportident user/passwort?
                                 -> and auch in Settings.Designer.cs
 * frmApiQueue.Designer.cs: viele Änderugnen
 * frmEntries.Designer.cs: wie kommt es zu dieser einen Veränderung?
 * FrmMain.Designer.cs: echt viele Änderungen!


## Datenbank abgleich   
* klc01.sql mit letztem export der Datenbank vergleich!
  * tabele [dbo].[_l] wurde angelegt?
  * q_content war nach auf 4000 begrenzt
  * TEXTIMAGE_ON [PRIMARY]
  * große Kaleder definition war noch enthalten? [dbo].[calendar]
  * cte_second_course anpassungen waren noch nicht aktiv?
  * CASE WHEN t.race_end > l.finish_dtime AND l.leg_status = 'OK' and sc.same_courses
  * sys.sp_addextendedproperty
 

#  IOF-XML Ergebniss Daten (online, wenn gewünscht)
   * es wird immer alles vollständig hochgeladen
   * Wettkampf muss zuvor angelegt sein.


