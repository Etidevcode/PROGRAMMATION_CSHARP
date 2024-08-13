Section 4 : Types et expressions C#
===

## Information
- Title:  `Types et expressions C#`
- Authors:  `Etienne KOA`




## Quizz

**Question 1 :**
Quels sont les 4 types non numériques intégrés en C# ?

*bool, char, object and string*

*Ces 4 types ne sont pas numériques.*

**Question 2 :**
Quelle est la différence entre les types C# `double` et `float` ?

*Un double a 52 bits de précision, float a 23 bits*

*Un double sera précis à 15 ou 16 chiffres, un float aura une précision à 7 chiffres.*

**Question 3 :**
Quelle est l'une des raisons pour lesquelles vous utilisez le type `décimal` plutôt que le type `double` dans votre programme ?

*Le type `decimal` est plus précis*

*Les calculs avec des décimales sont beaucoup moins susceptibles d'entraîner des erreurs d'arrondi.*

**Question 4 :**
Parmi les affirmations suivantes concernant le type décimal, lesquelles sont vraies ?

*Les calcules avec le type decimal sont environ 20 fois plus lents qu'avec le type double*
*Le type decimal a une precision supérieure au type double et est moins sensible aux erreurs d'arrondi*

*Ces deux affirmations sont vraies. Le type décimal offre une plus grande précision, au détriment des performances.*

**Question 5 :**
Qu'est-ce qu'une expression booléenne ?

*Une expression qui renvoie true ou false*

*Les valeurs booléennes ne peuvent avoir que les valeurs vraies ou fausses.*

**Question 6 :**
Compte tenu des déclarations suivantes :

```
                     int age;
                     int accidents;
                     bool licence;
                     bool canHireCar;

```

les variables reçoivent des valeurs avant que le code ci-dessous ne soit exécuté.

Laquelle des expressions ci-dessous sera évaluée comme vraie uniquement pour les clients :

```
                     between the ages of 21 and 89 (inclusive)
                     have had no accidents
                     have a licence to drive
```


```
canHireCar = (12 <= age && age <= 89)&&(accidents == 0)&&licence;
```

*Les 3 parties de la condition doivent être vraies. L'âge doit être compris dans la fourchette requise, ils ne doivent avoir aucun accident et ils doivent être titulaires d'un permis.*

**Question 7 :**
En référence à cette ligne de code :

```
bool canHireCar = (21 <= age && age <= 89) && (accidents == 0) && licence;
```

Parmi les affirmations suivantes, lesquelles sont vraies ?

Le code contient : 
   + *1 déclaration booléenne*
   + *6 déclarations booléennes*
   + *1 affectation booléenne*

*La variable booléenne `canHireCar` est déclarée et le résultat de l'expression booléenne composée lui est attribué.*

**Question 8 :**
Quelle est la différence entre une méthode de classe et un champ de classe ?

*Une méthode est membre d'une classe qui effectue des actions. Un champ est un membre d'une classe qui stocke les données d'état pour chaque instance de classe.*






