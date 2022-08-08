# RW-HPS_启动器 项目
## 声明
### 一切开发旨在学习，请勿用于非法用途
- RW-HPS_启动器 是完全免费且开放源代码的软件，仅供学习和娱乐研究用途使用
- RW-HPS_启动器 不会通过任何方式强制收取费用，或对使用者强制提出物质条件
### 许可证
- [AGPL-3.0](https://www.gnu.org/licenses/agpl-3.0.html)
<details>
  <summary>AGPL-3.0</summary>

```
Copyright (C) 2020-2022 RW-HPS Team and contributors.

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as
published by the Free Software Foundation, either version 3 of the
License.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
```
</details>

<details>
  <summary>EULA</summary>

```
版权所有©2022 RW-HPS.Team <RW-HPS@der.kim>

允许在其遵守CC BY-NC-SA 4.0协议的同时，每个人复制和分发此许可证文档的逐字记录副本，且允许对其进行更改，但必须保留其版权信息与原作者。

请务必仔细阅读和理解通用用户协议书中规定的所有权利和限制。在使用前，您需要仔细阅读并决定接受或不接受本协议的条款。除非或直至您接受本协议的条款，否则本软件及其相关副本、相关程序代码或相关资源不得在您的任何终端上下载、安装或使用。

您一旦下载、使用本软件及其相关副本、相关程序代码或相关资源，即表示您同意接受本协议各项条款的约束。如您不同意本协议中的条款，您则应当立即删除本软件、附属资源及其相关源代码。

本软件权利只许可使用，而不出售。

本协议与GNU Affero通用公共许可证(即AGPL协议)共同作为本软件与您的协议，且本协议与AGPL协议的冲突部分均按照本协议约束。您必须同时同意并遵守本协议与AGPL协议，否则，您应立即卸载、删除本软件、附属资源及其相关源代码。
```
</details>

`RW-HPS_启动器` 采用 `AGPLv3` 协议开源。为了整个社区的良性发展，我们**强烈建议**您必须明白以下几点：
- **不得使用一切手段通过反编译、逆向等行为获得未开源的数据/代码**
- **不鼓励，不支持一切商业行为使用**
- **本启动器是基于RW-HPS服务端来进行使用的，请勿拿着开源二改闭源等行为谎称自己开发并开放使用的**
  **本启动器是属于RW-HPS官方以外的团队开发！**
  **本启动器是基于RW-HPS的，所以如果RW-HPS有任何跑路等行为，启动器可能也会跟着（｡ò ∀ ó｡）**

### 衍生软件需声明引用

- 若引用 RW-HPS_启动器 发布的软件包而不修改 RW-HPS_启动器，则衍生项目需在描述的任意部位提及使用 RW-HPS。
- 若修改 RW-HPS_启动器 源代码再发布，**或参考 RW-HPS_启动器 内部实现发布另一个项目**，则衍生项目必须在**文章首部**或 'RW-HPS_启动器' 相关内容**首次出现**的位置**明确声明**来源于本仓库 (`[https://github.com/wanan12138/RW-Launcher](https://github.com/wanan12138/RW-Launcher)`) 不得扭曲或隐藏免费且开源的事实。


## 介绍
**RW-HPS_启动器**是一个基于RW-HPS（ https://github.com/RW-HPS/RW-HPS ）服务端的可视化GUI开服启动器
**RW-HPS**是一个运行在Rusted Warfare（铁锈战争）游戏的服务端,用于在运行Java8的服务器上快速建立高性能游戏服务器  
本启动器旨在为一个高性能 高可用的服务端做到方便快捷的开服操作 为服主提供更好的使用体验


## 所需前置程序：
- dotnet core/framework
- 以及。。。优秀的大脑子
- 还有一双无与伦比的手！


## 特点功能

**优秀的界面功能**
- 多服启动 多服共享一个面板但可以独立开启
- 流畅开关服务器
- 控制台颜色变化


#### 目前待完成
- [ ] 关于我们
- [ ] 美化界面
- [ ] 自动更新
- [ ] WEB面板
- [ ] 设置界面
- [ ] 命令输入
- [ ] 配置文件全汉化修改
- [ ] 动态MOTD显示服务器消息（需要等Dr支持API接口）


## 开始
- 用户手册: [docs](docs/zh/run/UserManual.md)
- 开发文档: [docs](docs/zh/README.md)
- 更新日志: [release](/releases)
- 开发计划: [milestones](/milestones)
- 讨论:
  > 在 GitHub Discussions 提出的问题会收到回复, 也欢迎分享你基于项目的新想法  
  > 腾讯QQ群: [901913920](https://qm.qq.com/cgi-bin/qm/qr?k=qhJ6ekYF9pD9jO6j8H2rZw8ePAVypoU0&jump_from=webapi)      
 **Dr的开发群，由于我们并没有建立群聊，所以可以加入这个**


## 运行配置
**很抱歉，由于开发比较着急，没有经过虚拟化等服务器测试**
| 配置 		| CPU                     | 内存 	| 系统 			 | 硬盘大小 	   | Java      |
|:--- 		|:------------------------|:---     |:-------|:---------|:---       |
| 建议配置 	| ARMv7 Processor rev 5 + | ∞MB      | Windows | ∞MB HDD | Java 11   |
| 最低配置 	| 任何                      | ∞M      | Windows     | ∞M HDD  | Java 11   |
  

## 赞助
RW-HPS_启动器是AGPL v3授权的开放源码项目，完全免费使用。然而，如果没有适当的资金支持，为项目维护和开发新功能所需的工作量是不可持续的。  
请注意，赞助是全自愿的。赞助者不会获得特权，不赞助也可以使用全部的功能。

我们通过以下渠道接受捐赠：  
+ [狗子爱发电]()
+ [晚安爱发电]()


## 感谢
> Dr开发者的RW-HPS提供授权以及大力帮助

> [IntelliJ IDEA](https://zh.wikipedia.org/zh-hans/IntelliJ_IDEA) 是一个在各个方面都最大程度地提高开发人员的生产力的 IDE，适用于 JVM 平台语言。

特别感谢 [JetBrains](https://www.jetbrains.com/?from=rw-hps) 为开源项目提供免费的 [IntelliJ IDEA](https://www.jetbrains.com/idea/?from=rw-hps) 等 IDE 的授权  
[<img src=".github/jetbrains-variant-3.png" width="200"/>](https://www.jetbrains.com/?from=rw-hps)
