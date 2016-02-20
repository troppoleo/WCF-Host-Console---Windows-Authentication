è un esempio semplice di progetto WCF che vuole 
dimostrare la windows authetication
prima ho creato una 
	"WCF service library"
ed ho aggiunto una funzione che restituisce chi sono e come sono autenticato
ho creato una console applicatione che serve per fare l'host del servizio creato
quindi nel main lancia il servizio e lo lascia in attesa:

using (ServiceHost host = new ServiceHost (typeof (ServiceLibrary.Service1)))
{
	host.Open();
	Console.WriteLine("Host started " + DateTime.Now.ToShortTimeString());
	Console.ReadLine();
}

va configurato correttamente l'app.config
ho copiato ed incollato l'app.config del "ServiceLibrary" così avevo una configurazione iniziale
poi ho cambiato baseAddress:
<add baseAddress = "http://localhost:8080" />
scegliendo una porta e rimuovendo tutte le informazioni che c'erano
dato che voglio verificare la windows autentication
ho impostato nell'endpoit binding="wsHttpBinding" al posto di quelle che c'era preconfigurato

rimane da creare il client:
ho proceduto così: ho aggiunto un progetto di windows form ed ho cercato di aggiungere la reference
al servizio ma non ci sono riuscito dato che non riesce a trovare il servizio se questo non è attivo
quindi ho provato ad avviare l'host in 
"Debug -> Start new instance" 
ma non riuscivo ad aggiungere il servizio perchè VS non me lo permette,
se invece premo il pulsate di "discover" non riesco a far puntare all'indirizzo "http://localhost:8080"
soluzione:
apro una nuova instanza di VS come amministratore e creo il nuovo client, per aggiungere la reference
faccio partire il progetto "Host" e adesso posso usare l'indirizzo "http://localhost:8080" 
e premere "GO" nello spazio per la ricerca dell'indirizzo al servizio.

a questo punto il servizio funziona correttamente

dato che ormai il client funzione ed è correttamente configurato ho chiuso il VS con il solo client
e nel progetto con l'host ho aggiunto il progetto del client.

NOTA: se devo modificare la configurazione del WCF per esempio per usare un altro tipo di binding
e quindi poi devo aggiornare il client, allora è meglio lavorare il client nella solution separata
dato che non saprei come aggiornare il servizio


ho preso spunto dal video:
https://www.youtube.com/watch?v=EWBgqfhAT9U
