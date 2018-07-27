# OverwatchLeagueAPI
A C# wrapper for the Overwatch League API.

**NOTICE:**
On July 20, 2018, the Overwatch League commissioner, Nate Nanzer, [made a post on Reddit.com](https://www.reddit.com/r/Competitiveoverwatch/comments/8z8ysf/the_dream_comes_true_match_stats_are_finally_here/e2p4tcl/) stating that the official API isn't quite ready for public consumption at this time. As such, work on this wrapper will recommence once Blizzard are ready to officially release their API to the public! 😀

## Requirements
- .NET Standard 2.0
- Newtonsoft's [Json.NET](https://www.newtonsoft.com/json) library - v. 11.0.2

## Installation instructions
- Clone or download it from Github as a .zip file.
- Build the library and add it to your application as a dependency.
- Additionally, also ensure that you add Newtonsoft.Json to your application as a dependency:
  - Go to "Project" > "Manage NuGet Packages"
  - Find "Newtonsoft.Json", click on it, and click "Install". Ensure that the version being installed is 11.0.2.

## Usage
Currently, the endpoint for retrieving the match details of a particular map is functional:
```c#
OverwatchLeagueApi api = new OverwatchLeagueApi();
Map map = await api.GetMapStats("10528", "1");
```
For further details, see the OverwatchLeagueAPI.Example project.

For all found endpoints, please see: [https://www.reddit.com/r/Competitiveoverwatch/comments/8z8ysf/the_dream_comes_true_match_stats_are_finally_here/](https://www.reddit.com/r/Competitiveoverwatch/comments/8z8ysf/the_dream_comes_true_match_stats_are_finally_here/)

## License
This repository is under the [MIT license](LICENSE.md).

## Disclaimer
This API is an unofficial wrapper for the Overwatch League API. This is not officially endorsed by or affiliated with Overwatch League, Blizzard Entertainment, Major League Gaming, Activision Blizzard, or any other party. This software available on the website is provided "as-is" and any expressed or implied warranties, including, but not limited to, the implied warranties of merchantability and fitness for a particular purpose are disclaimed. 

In no event shall the author of this source code, the owner of this repository, or any of this repository's contributors, be responsible or liable for any direct, indirect, incidental, special, exemplary, or consequential dmanages (including, but not limited to, procurement of substitute goods or services; loss of use, data, or profits; or business interruption) however caused and on any theory of liability, whether in contract, strict liability, or tort (including negligence or otherwise) arising in any way out of the use of this software, even if advised of the possibility of such damage.
