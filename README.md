# Projet de Conception et Développement Avancé d'Applications (Licence 3 - Semestre 1)

Il s'agit d'un ensemble de projets réalisé au cours du module afin de mettre en pratique les connaissances acquises en cours.

## Langage C#

###  Application gestion de magasins

Le but de l’application est de simuler la gestion d’un catalogue de produits et de magasins pour un site de commerce en ligne. Les magasins peuvent être par exemple des supermarchés comme GéantCasino, Carrefour, Leclerc, etc.

Un produit est décrit par un identifiant technique (code), un nom, un prix, une catégorie (Consommable ou NonConsommable) et une sous-catégorie (comme Epicerie sucrée, Epicerie Salée, etc.).

Un magasin est décrit par un identifiant, un nom, un numéro téléphone, une ville, et une liste de produits.

Pour compléter l’application de gestion, on prend en compte des produits spécifiques, à savoir les produits à risques. Ces produits comportent des règles de stockage spécifiques d’où le fait qu’il soit décrit en plus par le type de risque et le règlement de stockage les concernant.


Les fonctionnalités "métiers" pour cette application sont tout d’abord pour un magasin :
* L’ajout d’un produit
* La suppression d’un produit
* La récupération de la liste des produits
* La récupération d’un produit étant donné son code
* La récupération des produits d’une catégorie donnée
* La récupération des produits d’une sous-catégorie donnée
* La récupération des produits trié par leur code
* etc

L’application permet la gestion des produits à risques par :
* L’ajout d’un produit à risques
* La suppression d’un produit à risques
* La récupération de la liste des produits à risques

L’application permettant également de gérer plusieurs magasins, les fonctionnalités d’ajout, de récupération d’un ou plusieurs magasins selon certains critères, etc. sont présentes.


Les produits à risques étant un sous-ensemble de produit pour l’application, les fonctionnalités liées aux produits fonctionnent aussi sur les produits à risques à l’exception de l’ajout étant donné qu’il y a des informations supplémentaires à fournir lors de la création du produit.

Les fonctionnalités de l’application lié aux magasins sont, outres les fonctionnalités de recherches, des fonctionnalités d’ajout, de suppression et de sélection de magasin.

### Généricité

Le but de cette application est de mettre en pratique et d'expérimenter la notion de généricité par l'intermédiaire d'une classe **Panier**.

La classe **Panier**<T> est une classe générique faisant office de conteneur et qui possède 3 attributs :
* un tableau d’objets T,
* un entier constant qui détermine le nombre maximum d’objet pouvant être contenue dans le panier,
* un entier qui contient le nombre d’objet T contenue dans le panier.

Cette classe possède également plusieurs méthodes afin de remplir sa fonction :
* une méthode d’ajout,
* une méthode d’insertion,
* une méthode de tri basé sur le tri à bulles,
* une méthode de suppression,
* 2 méthodes de recherches,
* une méthode "appartient" vérifiant si un élément est déjà présent dans le tableau, permettant ainsi d’éviter les doublons.


Étant donné que le panier doit être utilisé pour contenir des éléments appartenant à des types utilisateur et que l’on souhaite pouvoir trier les éléments du panier on impose une contrainte concernant le type T qui sera contenu dans le panier.

La contrainte stipule que le type T doit nécessairement implémenté la classe ***IComparable***<T> . Cette classe permet d’implémenter la méthode CompareTo qui permet de faire une comparaison entre 2 objets pour ainsi déterminer lequel est le plus grand ou bien s’ils sont égaux. De cette façon il nous est possible de faire des comparaisons entre 2 éléments de type T pour ainsi pourvoir les trier.


Dans l’application la classe **Panier**<T> est utiliser afin de créer 2 panier : l’un étant un panier permettant de stocker des produits et l’autre étant un panier permettant de stocker des Livres. Durant l’exécution on peut choisir sur lequel des deux paniers l’on travaille et ainsi effectuer nos opérations sur celui-ci, ainsi le panier de produits et celui de livres sont complètement indépendants l’un de l’autre. 

### Collections non génériques et génériques

Le but de cette application est de mettre en pratique et d'expérimenter les collections non génériques et génériques au travers d'exemple permettant au minimum d’ajouter, insérer, trier (le cas échéant), supprimer et rechercher dans la collection. En résulte donc :
* La classe Magasin qui est une classe permettant le stockage d’élément de type **Produit** dans une SortedList.
* La classe Librairie qui est une classe permettant le stockage d’élément de type **Livre** dans un Dictionary.
* La classe Grenier qui est une classe permettant le stockage d’élément de type **Aliment** dans une Hashtable.

## Windows Forms

Le but de l’application est de permettre la mise en pratique des connaissances acquises sur Windows Forms en se basant sur le même sujet d'application de gestion de magasins que dans la première partie du premier projet.

Pour pouvoir tester facilement l’application, des méthodes d’initialisations ont été mises en place pour disposer de magasins avec des produits lors du lancement de l’application.

La fenêtre principale est une fenêtre divisée principalement en 3 parties : A gauche une * *TreeView* * pour l’affichage des produits et des magasins, et à droite une * *RichTextBox* * et une * *PictureBox* * pour afficher les descriptions des éléments sélectionnés dans l’arborescence ainsi que l’image du produit si l’élément sélectionné est un produit.

Les fenêtre ***AjoutProd***, ***AjoutProdARisques*** et ***AjoutMag*** sont des fenêtres qui utilisent principalement des éléments tel que des * *TextBox* *, des * *ComboBox* * ainsi que des boutons pour fonctionner, cependant elles n’utilisent pas de composants riches.

La fenêtre ***Suppression*** est une fenêtre utilisant une * *TreeView* * (sur la gauche) pour l’affichage des magasins et des produits, ainsi qu’une RichTextBox pour afficher la description des objets sélectionner dans la * *TreeView* *.

La fenêtre ***Recherche*** utilise une * *ComboBox* * pour choisir la recherche que l’utilisateur veut effectuer, une * *TextBox* * pour saisir les informations nécessaires pour la recherche et une autre * *ComboBox* * pour choisir le magasin dans lequel on veut effectuer la recherche, ainsi qu’une * *DataGridView* * pour l’affichage des résultats des recherches effectués.

## Application Web ASP.net modèle MVC

L’objectif du projet est d’implémenter l’application de gestion d’un magasin, avec la gestion d'un seul magasin, géré en singleton, et les fonctionnalités suivantes :
* Ajout d'un produit dans le magasin
* Affichage de tous les produit du magasin
* Affichage des informations détaillées d'un produit du magasin avec une recherche à partir de son numéro
* Affichage des informations détaillées d'un produit du magasin avec une recherche sur des critères au choix

Pour pouvoir tester facilement l’application, des méthodes d’initialisations ont été mises en place pour
disposer de produits dans le magasin lors du lancement de l’application.

En suivant l'architecture MVC, sont ajoutées au squelette généré sous Visual Studio :
1. Pour les Modèles
    - La classe **Magasin**
    - La classe **LesProduits**
    - La classe **Produit**
2. Pour les Vues
    - Une vue pour l'ajout de produit
    - Une vue pour la suppression de produit
    - Une vue pour le listage de produit
    - Trois vues pour l'affichage des détails des produits
    - Une vue pour chacune des méthodes de recherche
3. Pour les Contrôleurs
    - **AjouterController**
    - **SupprimerController**
    - **ListerController**
    - **AfficherController**
