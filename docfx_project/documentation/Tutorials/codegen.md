# Codegen

[![LDtkMonogame.Codegen](https://buildstats.info/nuget/LDtkMonogame.Codegen) ](https://www.nuget.org/packages/LDtkMonogame.Codegen/)

LDtk.Codegen package is a code generator that will create c# files for your entities from `.ldtk` files.
This means you can make the variable and set them in ldtk without having to copy the names into a script just so you can use them in your code.

## Setup

First you need to install the tool which is easy open up cmd/terminal and run

```shell
dotnet tool install --global LDtkMonogame.Codegen
```

With that now installed globally you can run it by typing 

```shell
ldtkgen
```

It will print a help message to the screen telling you how you can configure ldtkgen

## Automation

So running the tool on every `.ldtk` file you have and remembering the arguments to pass every time would get abit out of hand so you can automate that

```xml
<Target Name="Codegen" BeforeTargets="BeforeBuild">
    <Exec Command="ldtkgen -i Content/World.ldtk" />
</Target>
```
