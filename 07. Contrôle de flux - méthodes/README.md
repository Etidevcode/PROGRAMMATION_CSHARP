Section 7 : Contrôle de flux : méthodes
===

## Information
- Title:  `Contrôle de flux : méthodes`
- Authors:  `Etienne KOA`

## Quizz

**Question 1 :**
Si nous avons une classe Car et que nous en créons une instance :

```
Car myCar = new Car("Tim's car"); 
```

Parmi les éléments suivants, lesquels sont des exemples d'appel d'une méthode.

```
myCar.Accelerate(4);
```

*Correct. Cela appelle la méthode Accelerate, en passant 4 comme argument.*

**Question 2 :**
Parmi les affirmations suivantes concernant les constantes, lesquelles sont vraies ?

*Une variable `const` ne peut pas être modifié une fois qu'elle a été déclarée.*
*Les constantes peuvent rendre votre code beaucoup plus facile.*
*L'utilisation de constantes peut aider à éviter les bogues pouvant survenir si vous siasissez une valeur incorrecte.*

**Question 3 :**
Lequel de ces modificateurs d'accès peut être utilisé pour rendre un membre de classe disponible dans d'autres classes :

1. private

2. internal

3. public

*2 et 3*

*Correct. les modificateurs d'accès public et interne rendent tous deux le membre disponible en dehors de la classe.*

**Question 4 :**
Lequel de ces mots-clés peut être utilisé pour sortir d’une boucle ?

*break and return*

*Correct. break et return sortiront de la boucle.*

**Question 5 :**
Qu'imprimera ce code ?

```
        class Program
    {
        static void Main(string[] args)
        {
            int y = 12;
            int z;
 
            z = AddOne(y);
 
            Console.WriteLine($"{y}, {z}");
        }
 
        static int AddOne(int x)
        {
            x = x + x;
            return x;
        }
    }
```

*12, 24*

*Correct. La méthode s'ajoute la valeur de l'argument, puis renvoie le résultat. L'argument est passé par valeur et n'est pas modifié. `AddOne` n'est pas un bon nom pour cette méthode.*






