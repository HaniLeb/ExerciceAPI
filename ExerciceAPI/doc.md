# Notes 
Via Swagger !

Envoyer du HTML sur le site (PUT) avec clés privée

Accueil qui affiche tous les articles : (GET)
	Dernier article en entier et les autres un lien qui redirige vers l'article.

Titre(Nom Blog) :
	Dernier Article
		- [Entier]

	Autres articles
		- Liens

Etant donne un article HTML
Et un nom unique <permalien>
Et une clé privée valide

Quand on PUT /articles/<permalien>

Alors le contenu de GET /articles/<permalien> et le HTML Fourni

-> créer une clé privée 
