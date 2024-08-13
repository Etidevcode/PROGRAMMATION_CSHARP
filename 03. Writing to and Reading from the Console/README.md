Section 3 : Writing to and Reading from the Console
===

## Information
- Title:  `Writing to and Reading from the Console`
- Authors:  `Etienne KOA`


## Introduction

+ La classe concole fournit des moyens simples d'obtenir les commentaires de l'utilisateur et d'afficher du texte. C'est ce qu'on appelle les entrées/sorties de la console ou les E/S de la console.

+ Dans cette section nous allons :
   + Écrivez un programme de menu simple et voyez comment détecter une seule touche expresse dans notre code en utilisant la méthode `ReadKey`.
   + Utilisez la méthode `ReadLine` pour renvoyer une ligne d'entrée que l'utilisateur tape.
   + Utilisez la méthode `Parse` pour convertir la chaîne en nombre.

+ La classe console fournit 2 méthodes pour écrire sur la console : `WriteLine` et `Write`.
+ Nous parlerons de la façon dont l'interpolation `string` peut être utilisée pour inclure les valeurs des variables dans la sortie.


## Quizz

**Question 1 :**
Choisissez l'option qui décrit le plus précisément la différence entre les méthodes ReadLine et WriteLine.

*`ReadLine` est utilisé pour lire une ligne de texte que l'utilisateur saisit dans la console. `WriteLine` est utilisé pour afficher du texte sur la console.*

**Question 2 :**
En supposant que les variables ont été correctement déclarées, comment feriez-vous pour que votre programme attende que l'utilisateur appuie sur une touche du clavier ?

```
keyInfo = Console.ReadKey(true);
```

*La méthode `ReadKey` attendra qu’une touche soit enfoncée.*

**Question 3 :**
Nous avons vu comment inclure des valeurs variables dans notre sortie, en utilisant la concaténation et l'interpolation de chaînes .

Lequel de ces exemples est un exemple d' interpolation de chaîne ?

```
Console.WriteLine($"The answer is {answer}");
```

*`L'interpolation de chaîne` permet d'incorporer les noms de variables dans une chaîne. Il sera utilisé pour imprimer la valeur, à condition que la chaîne soit préfixée par un `$`.*

**Question 4 :**
Lequel de ces éléments est un exemple de concaténation de chaînes ?

```
Console.WriteLine("The answer is" + answer)
```

*Cela utilise la concaténation pour joindre la valeur de la réponse à la chaîne.*

**Question 5 :**
Combien y a-t-il de spécificateurs de format numérique standard ?

*9*

*Vous avez probablement déjà trouvé la liste complète sur https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings*


**Question 6 :**
Quel sera le résultat de cette ligne de code :

```
Console.WriteLine($"{0.15:P}");
```

*15.00%*

*La lettre `P` est un spécificateur de format. Il affiche le nombre multiplié par `100`, avec un symbole `%`.*













