Section 10 : classes
===

## Papar Information
- Title:  `Classes`
- Authors:  `Etienne KOA`


## OOP and classes

#### 1) Qu'est-ce qu'une classe

+ La documentation de Microsoft décrit une classe comme
`une structure de données qui encapsule un ensemble de données et de comportements qui appartiennent ensemble en tant qu'unité logique`
+ C'est peut-être une belle phrase à prononcer dans une interview, mais elle ne nous dit pas grand-chose sans une analyse plus approfondie.

#### 2) Encapsulation

+ Un mot clé, dans cette définition, est **encapsule**.
+ `L'encapsulation` est l'un des principes de base de la programmation orientée objet (POO).
+ Nous encapsulons les données et les comportements en les plaçant dans une classe.
+ Il y a bien sûr un peu plus que cela. Nous devons également décider quel accès fournir aux données et comment le fournir, mais c'est la classe qui encapsule les données et les comportements.

#### 3) Modèle objet

+ Pour notre discussion sur les classes, je vais modéliser un aéroport.
+ Les aéroports sont des endroits assez complexes.
+ Ils disposent d'au moins une piste, et d'au moins un terminal qui dessert la piste.
+ Ou peut-être que la piste dessert le terminal ? Si cela semble un peu vague, c'est délibéré.
+ Nous pouvons souvent modéliser les choses de différentes manières.
+ Plus quelque chose est complexe, plus il existe généralement de façons de le modéliser.
+ La façon dont vous choisirez de le modéliser dépendra de ce que vous essayez de faire.
+ Pendant que nous parcourons ces exemples, gardez l'esprit ouvert et réfléchissez s'il existe différentes façons de penser les choses.
+ Je signalerai des alternatives possibles, de temps en temps, pour souligner qu'il n'y a pas de façon unique et « correcte » de faire les choses.

#### 4) Héritage

+ Les aéroports peuvent également avoir des magasins et des restaurants.
+ En fait, si nous avions déjà modélisé un centre commercial, nous pourrions considérer notre aéroport comme un centre commercial avec pistes.
+ Notre aéroport pourrait hériter d'une grande partie de ses fonctionnalités d'un modèle de centre commercial.
+ C'est un autre principe important de la POO - « l'héritage ».
+ En utilisant « l'héritage », nous pouvons étendre ou modifier le comportement d'une classe, pour en produire une version spécialisée.
+ Dans cet exemple, l'Airport hérite de tous les attributs d'une classe Shopping Mall
+ Il étend le modèle Mall, en ajoutant des Terminaux
+ Souvent, il y a de nombreux magasins et restaurants dans chaque Terminal
+ Une autre façon de modéliser l'aéroport pourrait être de traiter le terminal comme un centre commercial avec des pistes.
+ Un aéroport a un Terminal, et les Terminaux héritent des membres d'un Shopping d'un Centre Commercial
+ Les terminaux étendent le modèle du centre commercial en incluant des pistes

#### 5) Conception

+ Concevoir le modèle le plus approprié « pour votre application particulière » est la partie la plus difficile de la programmation orientée objet.
+ Le design peut convenir à certaines applications.
+ Mais réfléchissez à ce qui se passe si vous ajoutez un nouveau terminal à l'aéroport.
+ Serait-il facile de placer des magasins dans le terminal ?
+ Les magasins appartiendraient à l'aéroport, car il a hérité de ce genre de choses de la classe des centres commerciaux.
+ C'est très bien, la classe Shop a probablement un champ de localisation, et nous pouvons l'utiliser pour spécifier dans quel terminal elle se trouve.
+ Avec cette conception, les instances Shop appartiendraient automatiquement à un terminal.
+ C'est parce qu'ici, c'est la classe Terminal qui hérite de la classe Shopping Mall.
+ Ce serait également le cas si nous avions décidé qu'un terminal dessert la piste.
+ Nous avons cependant encore d’autres questions à considérer.
+ Un terminal peut-il desservir plus d'une piste ?
+ Une piste peut-elle desservir plus d'un terminal ?
+ Ou peut-être que les deux cas pourraient être vrais. Une piste pourrait fournir des passagers à plus d'un terminal, et un terminal pourrait recevoir des passagers de plus d'une piste.
+ Il est très important de bien concevoir votre projet.
+ Malheureusement, il n'est pas facile de savoir ce qu'est le « droit ».
+ D'autant plus qu'il y a souvent plus d'un modèle qui fonctionnera.
+ Nous appliquerons les principes de la conception POO dans nos exemples, et vous apprendrez également beaucoup en examinant comment les classes `.NET` de Microsoft sont organisées.
+ Nous allons regarder la classe Collections dans cette section, par exemple.
+ Concevoir vos cours pour qu'ils fonctionnent bien ensemble s'accompagne d'expérience.
+ Soyez prêt à faire beaucoup d'erreurs et à recommencer.
+ La bonne nouvelle est que cela devient vite évident lorsqu'une conception ne fonctionne pas.


#### 6) Polymorphisme

+ Le « polymorphisme » est un autre principe de la « POO ».
+ `Polymorphisme` signifie `plusieurs formes`, et utilisons un objet à la place d'un autre.
+ J'ai une méthode qui voulait un « carré », et nous lui avons donné un cercle, ce n'est pas vrai, ce n'est peut-être pas trop content.
+ `C#` est un langage strictement typé, et vous ne pouvez pas passer int lorsque des chaînes sont attendues.
+ Vous ne pouvez pas non plus passer un cercle si un carré est attendu.
+ Mais et s'il voulait seulement calculer la superficie ?
+ Dans ce cas, tout ce qui l'intéresse vraiment, c'est qu'il obtienne une « Formes ».
+ Si notre carré et notre cercle se comportent tous deux comme des formes, alors il ne devrait y avoir aucun problème à les utiliser.
+ C'est en un mot le « polymorphisme ».
+ Il y a plus à faire, et il existe différentes façons de l'implémenter, mais c'est une description de haut niveau du « polymorphisme ».
+ Vous pourrez peut-être repérer un problème avec ce que je viens de décrire.
+ Et si la méthode savait seulement calculer l'aire en multipliant la longueur de 2 côtés adjacents.
+ Cela devrait lui permettre de travailler avec des rectangles ainsi qu'avec des carrés, mais il ne gérera pas très bien un cercle.
+ Le calcul de l'aire d'un cercle est très différent de l'aire d'un carré.
+ Et si on lui donnait un triangle ?
+ Il serait capable de trouver 2 côtés adjacents d'un triangle, mais les multiplier pour trouver l'aire ne fonctionnerait pas.


#### 7) Abstraction
+ La réponse à ce problème est résolue par le 4ème principe de `POO`n, quelque chose appelé `abstraction`.
+ Fondamentalement, « abstraction » signifie que nos fonctions ont pour tâche d'essayer de définir l'aire de nos formes.
+ C'est quelque chose que les formes devraient savoir faire.
+ Ils « encapsuleront » la méthode pour faire cela et garderont pour eux les détails de « comment » ils le font.
+ `Abstraction` autorise en quelque sorte l'`encapsulation`.
+ Une fois que vous avez encapsulé les données, vous ne les exposez pas à l'extérieur du monde.
+ Nos formes auront toutes un moyen de fournir leur surface à tout programme qui le demande.
+ Mais le programme n'a pas besoin de savoir qu'ils le font.
+ Il peut être utile de considérer « l'encapsulation » comme s'appliquant aux « données » d'une classe, et « l'abstraction » comme s'appliquant à son « interface publique ».
+ Les détails du « comment » la classe fonctionne ne peuvent pas être appliqués à l'aide de la classe.
+ Le code appelant saura ce que la propriété `Area` lui donnera, mais n'a aucune idée de comment cela sera calculé.