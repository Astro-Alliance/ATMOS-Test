## Aggiungere il supporto High DPI (Dots per Inch) a programmi Windows Forms


1. Creare un file di manifest del programma

	Se nella cartella del progetto non c'è già un file `app.manifest`, dovrai crearne uno nuovo.
	Da Visual Studio:
	 1. Solution Explorer, tasto destro
	 2. _Add_ > _New Item..._
	 3. Tra i template di Visual Studio, scegli "Application Manifest File" e chiamalo `app.manifest`


2. Sostituisci il contenuto del manifest del tuo progetto con il contenuto del manifest del mio programma di esempio.
	
	Ho già impostato io tutte le opzioni per il DPI scaling. Non fare copia da Esplora File, devi copiare il contenuto.


3. Apri il file `Application.Designer.vb` del tuo progetto. Di solito questo file è nascosto dal Solution Explorer,
   quindi da Visual Studio devi fare _File_ > _Apri_ > `CartellaProgettoATMOS\My Project\Application.Designer.vb`


4. Assicurati che ci siano due linee di codice uguali a queste:

	```
	MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
	Me.EnableVisualStyles = true
	```


5. Se (e solo se) non ci sono, aggiungi solo questo, NON quello di prima:

	```
	Application.EnableVisualStyles()
	```
