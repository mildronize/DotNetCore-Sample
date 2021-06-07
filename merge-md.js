const { exec } = require("child_process");
const { readdirSync } = require("fs");
const fs = require("fs");

const getDirectories = (source) =>
  readdirSync(source, { withFileTypes: true })
    .filter((dirent) => dirent.isDirectory())
    .map((dirent) => dirent.name);

const getNoHiddenDirectories = (directories) => {
  return directories.filter( directory => directory[0] != '.' );
};

const directories = getNoHiddenDirectories(getDirectories("."));
const readFile = path => fs.readFileSync(path, 'utf8');
const writeFile = (path, content) => fs.writeFileSync(path, content)

let data = "";
data += readFile("scripts/HEAD.md");
data += "\n";
for (let i in directories){
  if(directories[i] == "node_modules") continue;
  if(directories[i] == "scripts") continue;
  data += "- ["+directories[i]+"](https://github.com/SukrepCode/DotNetCore.Templates/tree/main/"+directories[i]+")\n";
}
data += readFile("scripts/SPLIT.md");
regexImageMarkdown = /\!\[.*\]\((.*)\)/;
for (let i in directories){
  if(directories[i] == "node_modules") continue;
  if(directories[i] == "scripts") continue;

  data += "\n\n`"+directories[i]+"`\n";
  tmp = readFile(`${directories[i]}/README.md`);
  tmp = tmp.replace(regexImageMarkdown, `![${directories[i]} preview](${directories[i]}/$1)`);
  tmps = tmp.split("<!-- more -->");
  data += tmps[0];
  data += readFile("scripts/SPLIT.md");
}

data += readFile("scripts/TAIL.md");
writeFile("README.md", data);

