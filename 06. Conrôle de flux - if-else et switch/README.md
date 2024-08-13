Section 6 : Contrôle de flux : If/else et Switch
===

## Information
- Title:  `Contrôle de flux : If/else et Switch`
- Authors:  `Etienne KOA`


## Quizz

**Question 1 :**
Le matériau est disponible en différentes largeurs. Nous avons du matériel en largeurs de 36 pouces et 60 pouces.

Notre modèle de robe nécessite 150 pouces de tissu de 36 pouces de large, mais seulement 80 pouces de tissu de 60 pouces de large.

Laquelle de ces conditions sera correctement remplie si nous avons suffisamment de tissu pour confectionner une robe ?

```
        if (width == 36 && length >= 150 || width == 60 && length >= 80)
        {
          Console.WriteLine("Make a dress");
        }
```

*Correct. Des parenthèses pourraient être utilisées pour rendre la condition plus lisible ; if ((width == 36 && length >= 150) || (width == 60 && length >= 80))*

**Question 2 :**
Quel sera le résultat de cette boucle for ?

```
        for (int month = 1; month <= 12; month++)
        {
          Console.Write(month);
          if (month == 7)
          {
            break;
          }
        }
```

*1 2 3 4 5 6 7*

*La méthode `Write` imprime chaque valeur sur la même ligne et le `break` termine la boucle après l'impression de 7.*

**Question 3 :**
Si nous avons ces déclarations :

```
            bool printing = true; 
            int month = 0; 
```


Laquelle de ces boucles ne produit pas le même résultat que les autres ?

```
        while (mont <= 7)
        {
          month++;
          Console.WriteLine($"{month, 3:D2}")
        }
```

*La valeur du mois est incrémentée APRÈS que la condition ait été testée, donc cette boucle imprimera également 08.*

**Question 4 :**
Dans cet exemple, les accolades et les sauts de ligne ont été omis pour mieux s'adapter à vos écrans. Les accolades ne sont pas nécessaires lorsqu'un bloc de code ne contient qu'une seule ligne de code. Il est cependant considéré comme une bonne pratique de les utiliser.

Pourquoi devrions-nous utiliser else ou else if , plutôt que de simplement empiler une série de blocs if les uns en dessous des autres ?

```
For example, why should we write this           Instead of writing it like this?
if (day == 1) dayName = "Monday";               if (day == 1) dayName = "Monday";
else if (day == 2) dayName = "Tuesday";         if (day == 2) dayName = "Tuesday";
else if (day == 3) dayName = "Wednesday";       if (day == 3) dayName = "Wednesday";
else if (day == 4) dayName = "Thursday";        if (day == 4) dayName = "Thursday";
else if (day == 5) dayName = "Friday";          if (day == 5) dayName = "Friday";

```

*Le code de gauche est plus efficace. Le code de droite testera les 5 conditions, même si une condition antérieure est évaluée comme vraie.*

*Lorsque vous avez une série de conditions comme celle-ci, il ne sert à rien de tester les conditions suivantes après avoir déjà trouvé une correspondance.*

**Question 5 :**
Que fait ce code?

```
        switch (month)
        {
            case 2:
                days = 28;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                days = 30;
                break;
            default:
                days = 31;
                break;
        }
```

*Il donne à jours le nombre de jours dans le mois (bien qui'il ne gère pas les années bissextiles et que le mois 2 aura toujours 28 jours).*

