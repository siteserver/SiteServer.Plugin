# SiteServer.Plugin SiteServer CMS 插件开发包

SiteServer CMS 插件是扩展 SiteServer CMS 产品核心功能的代码包，SiteServer CMS 插件由.NET代码和其他文件(如图片、CSS和JavaScript等)组成。

通过插件可以扩展 SiteServer CMS，在 SiteServer CMS 已经提供的功能基础上构建额外的功能。例如，编写一个插件来控制对应栏目的内容模型，采用自定义的字段提交并显示内容文章；或者，可以编写一个插件，创建一个带有短信通知、支持第三方支付的全功能票务系统。

一个插件必须有的文件是：一个主文件（插件Id.dll）以及一个插件配置文件（插件Id.nuspec）。

## SiteServer CMS

SiteServer CMS 是基于.NET平台的一款免费，[开源](https://github.com/siteserver/cms)的内容管理系统，能够以最低的成本、最少的人力投入在最短的时间内架设一个功能齐全、性能优异、规模庞大并易于维护的网站平台。

## Status

稳定版 `(master)` ：


[![Build status](https://ci.appveyor.com/api/projects/status/dv89ciqao5u9fjgv/branch/master?svg=true)](https://ci.appveyor.com/project/starlying/siteserver-plugin/branch/master)

[![NuGet](https://img.shields.io/nuget/v/SiteServer.Plugin.svg)](https://www.nuget.org/packages/SiteServer.Plugin)


开发版 `(dev)` ：

[![Build status](https://ci.appveyor.com/api/projects/status/dv89ciqao5u9fjgv/branch/dev?svg=true)](https://ci.appveyor.com/project/starlying/siteserver-plugin/branch/dev)

[![MyGet](https://img.shields.io/myget/siteserver/vpre/SiteServer.Plugin.svg)](https://myget.org/feed/siteserver/package/nuget/SiteServer.Plugin)