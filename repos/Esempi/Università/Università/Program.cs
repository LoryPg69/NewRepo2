using System;
using System.Collections.Generic;
using Università;

Dictionary<Esame, Voti> esami = new Dictionary<Esame, Voti>();
esami.Add(key: new Esame() { nome = "storia" }, value: new Voti { voto = 10 });
esami.Add(key: new Esame() { nome = "matematica" }, value: new Voti { voto = 5 });

Dictionary<Matricola, Dictionary<Esame, Voti>> d1 = new Dictionary<Matricola, Dictionary<Esame, Voti>>();
esami.Add(key: new Matricola() { matricola = 5435 }, value: new Voti { voto = 10 });
esami.Add(key: new Matricola() { matricola = 5222 }, value: new Voti {  });

//Dictionary <Dictionary< Corsi, Dictionary<Matricola, Dictionary<Esame, Voti>>> uni = new Dictionary< Corsi, Dictionary< Matricola, Dictionary < Esame, Voti >>> ();
//esami.Add(key: new Matricola() { matricola = "storia" }, value: new Voti { voto = 10 });
//esami.Add(key: new Matricola() { nome = "matematica" }, value: new Voti { voto = 5 });

foreach (var esame in esami)
{
    Console.WriteLine($"esame: {esame.Key.nome} \nvoto {esame.Value.voto}");
}
