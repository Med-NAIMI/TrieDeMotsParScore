# TrieDeMotsParScore
Énoncé :
Soit un jeu de données contenant :
∞ Une chaine de caractère S, formée d’une séquence alternée de lettres
et de nombres entiers positifs, séparés par des espaces (toujours en
minuscule).
∞ Une liste de mots W, (chaines de caractères toujours en minuscule).
À chaque mot, on peut associer un score qui correspond à la somme des
scores de chaque lettre tels qu’indiqués dans la chaine S. Si une lettre n’est
pas présente dans S, son score est de 0. Vous devez réaliser un programme
qui lit un jeu de données et retourne les mots triés par ordre décroissant de
score. En cas d’égalité de score entre deux mots, ils doivent être écrits dans
l’ordre qui était le leur en entrée.
 Exemple :
Pour :
∞ S = "a 1 b 3 c 3 d 2 e 1 f 4 g 2 u 1".
∞ W = { "cafe", "button", "face", "bad", "zebra", "bug" }.
Dans notre exemple les mots correspondent aux scores suivants :
cafe 3+1+4+1=9
button 3+1+0+0+0+0=4
face 4+1+3+1=9
bad 3+1+2=6
zebra 0+1+3+0+1=5
bug 3+1+2=6
La sortie attendue serait donc :
cafe
face
bad
bug
zebra
button
