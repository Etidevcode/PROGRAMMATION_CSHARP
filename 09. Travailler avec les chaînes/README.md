Section 9 : Travailler avec les chaînes
===

## Information
- Title:  `Travailler avec les chaînes`
- Authors:  `Etienne KOA`


## Quizz

**Question 1 :**
Qu'est-ce qu'une chaîne en C# ?

*Une séquence de zéro ou plusieurs caractères Unicode.*


**Question 2 :**
Quel sera le résultat du code suivant ?

```
            static void Main(string[] args)
            {
              string description = "C# indexes start at zero";
              Console.WriteLine(description[3]);
            }
```

*i*

*Correct, la lettre i est le quatrième caractère de la chaîne, à la position d'index 3.*

**Question 3 :**
Laquelle de ces boucles parcourra correctement tous les caractères d'une chaîne.

Supposons que courseName a été déclaré comme type string et a été initialisé.

```
        for (int i = 0; i < courseName.Length; i++)
        {
          Console.WriteLine(courseName[i]);
        }
```

**Question 4 :**
Laquelle de ces valeurs StringComparison peut être utilisée pour comparer 2 chaînes, en effectuant une recherche insensible à la casse et en prenant en compte la langue actuelle ? 

*CurrentCultureIgnoreCase*

*Correct. La comparaison ignorera la casse des chaînes et les comparera en utilisant les règles de la langue actuelle.*

**Question 5 :**
Laquelle de ces affirmations est fausse ?

*Vous devez comparer les valeurs de chaînes à l'aide de l'opérateur ==*

*Correct. Bien que `==` puisse être utilisé pour comparer des valeurs de chaîne en `C#`, ce n'est pas le seul moyen et la méthode `.Equals()` est préférée.*

**Question 6 :**

Lequel de ces énoncés est correct?

1. Lorsque nous copions un type référence, la valeur est copiée dans l'emplacement mémoire de la nouvelle variable.

2. Lorsque nous copions un type référence, la référence est copiée dans l'emplacement mémoire de la nouvelle variable.

3. Lorsque nous copions un type valeur, la référence est copiée dans l'emplacement mémoire de la nouvelle variable.

4. Lorsque nous copions un type valeur, la valeur est copiée dans l'emplacement mémoire de la nouvelle variable.

*2 et 4*

*Correct, les types référence sont copiés par référence, les types valeur sont copiés par valeur.*

**Question 7 :**
Que se passe-t-il lorsque nous utilisons la méthode `.Remove()` de la classe string ?

*Une nouvelle chaîne est crée.*

*Correct, les chaînes `C#` sont `immuables` et ne peuvent pas être modifiées.*

**Question 8 :**
Laquelle de ces instructions décrit correctement la classe StringBuilder ?

*Les instances de la classe `StringBuilder` peuvent être modifiées et référencer le même objet*

**Question 9 :**
Laquelle de ces paires de méthodes n’est pas disponible pour la classe StringBuilder ?

*IndexOf et Contains*

*Correct. Les StringBuilders sont destinés à modifier les valeurs de chaîne et ne sont pas très efficaces pour la recherche.*











