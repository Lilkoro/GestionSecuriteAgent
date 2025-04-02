# Gestion Sécurité Agent

## Description
Projet de gestion des agents de sécurité développé en C# avec WinForms. Cet outil permet de suivre et gérer les agents, leurs affectations et les incidents.

## Fonctionnalités prévues
- Gestion des agents de sécurité
- Attribution des missions et des postes
- Suivi des incidents et rapports
- Génération de statistiques et rapports d'activité
- Intégration avec une base de données MySQL

## Technologies utilisées
- **Langage :** C#
- **Framework :** .NET (WinForms)
- **Base de données :** MySQL

## Installation
1. Cloner le dépôt :
   ```sh
   git clone https://github.com/Lilkoro/GestionSecuriteAgent.git
   ```
2. Ouvrir le projet avec Visual Studio.
3. Configurer la connexion à la base de données MySQL.
4. Importer la base de données fournie :
   - Ouvrir MySQL et créer une base de données (ex: `gestion_securite`).
   - Importer le fichier SQL fourni en exécutant :
     ```sh
     mysql -u utilisateur -p gestion_securite < chemin/vers/le/fichier.sql
     ```
   - Modifier la chaîne de connexion dans l'application pour correspondre aux identifiants de votre base de données.
5. Compiler et exécuter le projet.

## Contribution
Les contributions sont les bienvenues ! Pour proposer des modifications :
1. Forker le projet
2. Créer une branche (`feature-nom`)
3. Soumettre une pull request

## Licence
Ce projet est sous licence MIT.
