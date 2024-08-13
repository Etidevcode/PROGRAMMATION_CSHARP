Section 8 : Opérateurs
===

##  Information
- Title:  `Opérateurs`
- Authors:  `Etienne KOA`


## Quizz

**Question 1 :**
Lequel des énoncés suivants décrit correctement l'ordre d'évaluation de cette expression

```
            static void Main(string[] args)
            {
              int x = 1 + 3 * 15 / 2;
              Console.WriteLine(x);
            }
```       


N'oubliez pas que nous effectuons ici une division entière .

*1 + ((3 * 15) / 2) pour donner 23*

*Correct. La multiplication et la division ont la même priorité et sont évaluées de gauche à droite. Ils ont tous deux une priorité plus élevée que l’addition.*

**Question 2 :**
Quelle est la différence entre les opérateurs post-incrémentation et pré-incrémentation ?

*L'opérateur de post-incrémentation, `++`, vient après la variable. La vraible est incrémentée après le renvoi de la valeur, ce qui entraîne le renvoi de la valeur d'origine. L'opérateur de pré-incrémentation précède la variable, ce qui signifie que la variable est incrementée avant que la valeur ne soit renvoyée, ce qui entraine le renvoi de la nouvelle valeur.*

*Correct. Mais la difficulté de se rappeler dans quel sens les choses se produisent est une bonne raison pour ne pas utiliser ces opérateurs sur le côté droit d'une affectation.*

**Question 3 :**
Lesquelles des paires d'expressions suivantes sont équivalentes

```
x != y
!(x == y)
```

*Correct. La négation de l'expression "x == y" équivaut à "x != y".*

**Question 4 :**
Quel sera le résultat de l’exécution de ce code ?

```
            double x = 1 + 3 * 15 / 2;
            double y = 1 + 3 * 15 / 2.0;
            Console.WriteLine($"{x}, {y}");

```

*x sera 23, y sera 23.5*

*Correct. La première expression effectue une division entière.*

**Question 5 :**
Parmi les affirmations suivantes, lesquelles sont vraies ?

*La division entière en virgule flottante donne une partie fractionnaire d'un résultat. La division entière renvoie uniquement la partie entière d'un résultat. La division entièere est effectuée si les deux opérandes sont des nombres entiers. C'est le cas même lorsque le résultat est affectée à une variable à virgule flottante.*

**Question 6 :**
Compte tenu des déclarations suivantes :

```
            bool x = false; 
            bool y = true; 
            bool z = true; 
```

L'expression

x && y || z

évaluer à vrai ou faux ?

*Vrai*

*&& a une priorité plus élevée que ||*

