Console.WriteLine("Hello, World!");

//Aufgabe 3 
/*Es gibt keine Standard-Konstruktoren mehr, d. h. beim Erzeugen der Objekte müssen
immer alle notwendigen Daten angegeben werden.

 Das Setzen von Vor- und Nachname soll nur noch beim Instanziieren der Mitarbeitenden
möglich sein. Die entsprechenden Setter der Oberklasse werden auf die
Sichtbarkeitsstufe private geändert.

 Analysieren Sie die nun auftretenden Fehler. -> Fehler in Klasse: CAngestellte (Konstruktor)
                                               -> Zugriff auf Methode SetVorname und Nachname nicht mehr möglich

Lösung: Setter in Oberklasse in Konstruktor gelegt und in Unterklasen : Base(nn,vn) für Vor und Nachname verwendet 
Setter Methode rausgeworfen

 Informieren Sie sich darüber, wie der aufgerufene Basisklassenkonstruktor angegeben
werden kann, wenn Instanzen einer abgeleiteten Klasse erstellt werden (Schlüsselwort
base beim Konstruktor der Unterklasse) und ergänzen Sie Ihren Quelltext dementsprechend*/