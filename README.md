# florescerAPI

## 🐱 Github:

1. Primeiro faça clone do repositório

```bash
git clone linkdorepositorio
```

2. Atribua uma tarefa a você no [Jira](https://florescer.atlassian.net/jira/software/projects/FLC/boards/1), depois copie a branch que o jira disponibiliza

```bash
git checkout -b nomeDaBranchDoJira
```

3. Faça sua tarefa e commits

```bash
git commit -m "descreva brevemente o que foi feito"
```

4. Depois de finalizada sua tarefa faça um push

```bash
git push origin nomeDaBranchQueVoceEsta
```

5.  Agora abra seu github no navegador e vá até o repositório do florescer e peça um pull request e aguarda as correções ou merge.

6.  Depois que sua tarefa for aprovada e mergeada você pode pegar uma nova tarefa. Mas antes de criar uma nova branch lembre-se:

```bash
git checkout main

git pull

git checkout -b nomeDaBranchDoJira
```

## 🛠️ Preparando o ambiente:

1. Crie o Banco de dados no postgre com o nome 'FlorescerDb'

2. No arquivo appsettings.json passe a porta, senha e usuário do seu banco de dados.

3. Se estiver usando Visual Studio: No PackageManagerConsole execute o comando 'update-database' para que as migrations sejam aplicadas no banco (criação das tabelas). 
   Se estiver usando Visual Studio Code: Deves executar o comando via CLI na pasta onde está o arquivo projeto .csproj: 'dotnet ef database update', para que as migrations sejam aplicadas no banco (criação das tabelas).

4. A documentação de funcionamento da api está no swagger (ao executar a aplicação, o swagger abrirá automaticamente.)

5. Ao testar os endpoints no swagger, insira o token jwt dessa maneira: Bearer {seu token}, para receber autorização. Se não enviar a palavra Bearer antes do token, não irá funcionar!!!

6. Se o swagger não abrir automaticamente no navegador, inserir na url: http://localhost:5049/swagger/index.html


## 🛠️ Alterando o banco de dados via entity:
1. Rodar o comando CLI para criação da migration:
```bash
dotnet ef migrations add NomeDaMigration --context minimalcontextdb
```

2. Aplicar a migration no banco usando o comando CLI:
```bash
dotnet ef database update --context minimalcontextdb
```

----------------------------------------------
Qualquer dúvida, só me Chamar :-)
Wagner.

