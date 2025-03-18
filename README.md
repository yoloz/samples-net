# samples-net

## AdoNet

`ADO.NET`（ActiveX Data Objects for `.NET`）是一个在`.NET`中用于数据访问的框架。`ADO.NET` 提供了一组类，用于连接到数据源、执行命令以及检索和更新数据。

1. 下载安装[NET SDK](https://dotnet.microsoft.com/zh-cn/download)；
2. 打开 VSCode 工具，安装`C#`相关 plugin,然后`Ctrl+Shift+P`选择`.NET:New Project...`,选择`Console App`(工程模板按需选择)，然后输入工程名选择路径即可；
3. 函数运行入口在`Program.cs`

`The type name 'SqlConnection' could not be found in the namespace 'System.Data.SqlClient'. This type has been forwarded to assembly 'System.Data.SqlClient, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' Consider adding a reference to that assembly.`

在`.NET Core` 或 `.NET 5+` 项目中，`System.Data.SqlClient` 不再是默认包含的一部分，需要手动[添加](https://www.nuget.org/packages/System.Data.SqlClient),此处使用`.NET CLI`方式：`dotnet add package System.Data.SqlClient --version 4.9.0`

> 'SqlConnection' is obsolete: 'Use the [Microsoft.Data.SqlClient](https://learn.microsoft.com/zh-cn/sql/connect/ado-net/introduction-microsoft-data-sqlclient-namespace) package instead.'

添加依赖：

```bash
# System.Data.SqlClient is deprecated. Please use Microsoft.Data.SqlClient instead.
$ dotnet add package System.Data.SqlClient --version 4.9.0
# dotnet remove package System.Data.SqlClient
$ dotnet add package Microsoft.Data.SqlClient --version 6.0.1
$ dotnet add package MySql.Data --version 9.2.0
```
