# TAS-Competition-Compiler-Display-Tool
A tool used to track progress in TAS competitions, full with submission and point tracking.

The latest version can be [found here](https://github.com/TimeTravelPenguin/TAS-Competition-Compiler-Display-Tool/releases)!
## Current features:
- Simple tools to save data on competitor's information including username, start and end frames, disqualification comments, and a points leaderboard for multi-task competitions
- Saving and loading file
- Plain text output for both the competition leaderboard and the points leaderboard

## Coming soon:
- Live output of competitor information to use with livestream information display. You can output one user at a time, displaying their place, name, time, etc. so it can be displayed on stream

# How to use TASCCDT
### [Click here for video demonstration](https://www.youtube.com/watch?v=AwPjAeGKUu8)
Here is the main window you will see upon launching v0.1.3:

![img 1](https://i.imgur.com/AMWakhA.png)

To begin, start by filling out the textboxes, then hitting the **ADD** button to add them to the datagrid.
You can, if desired chose disqualification reasons, should the user who submit have broken the rules of the competition.

![img 2](https://i.imgur.com/Dc4yzHY.png)

Alternitively, you can open a prexisting .TASc file from `File > Open > Competition Leaderboard`

Once added, items should automatically sort themselve such that the smallest time is ranked 1st. DQ'd submissions are all equally ranked last.

![img 3](https://i.imgur.com/Dc4yzHY.png)

Naturally, you can see what the comments are by hovering over the comments cell

![img 4](http://imgs.fyi/img/6t2f.png)

As mentioned before, you can indevidually open/save both the competition leaderboards and points leaderboards into a custom .TASc and .TASs file, respectively. The different file extensions help to distinguinsh each type of file.

![img 5](http://imgs.fyi/img/6t2g.png)

By hitting the "Score Points" button in the top toolbar, scores all the runners in the compeition. If you have a .TASs file open, the scores of existing users are added to their previous score. If not, they are added as a new user. Users who have been DQ'd will not score any points. The current scoring formula is the one seen [here](https://docs.google.com/spreadsheets/d/e/2PACX-1vSL-uZkslyP4tnQcprS_aR1-ZQNduVH3MvdpVyiAZPWA9g25RlyhlJVMNri3r3HqrmVhyb54Mw1pAlt/pubhtml).

![img 6](https://i.imgur.com/MxHoLxd.png)

Once ready to export to release the results of the competition, you can chose what to export as plaintext from the "Export Plain Text" toolbar option. You can export both the competition and points leaderboards.

![img 7](https://i.imgur.com/J8Anx0Q.png)

Depending on the number of submitees, the number of bolded names at the top of each list changes. The competition export has a max of 5, where the point export has a max of 3 bolded names.

![img 8](https://i.imgur.com/y7qY2ST.png)

The final section of the program is the `Live Display`, which outputs one competitor's information to a file, to display on a live stream. You can then toggle each competitors information one at a time, going from last place, to first, then from slowest DQ to fastest.

To get to this tool, click the `Live Display` toolbar option. Once clicked a window diaplaying, by defualt, the current competitor's information. Clicking the dedicated checkbox enables the viewing of the next competitors run.

![img 9](https://i.imgur.com/t014B7I.png)

On first use, the program will ask for a file destination. This is remembered between sessions unless the program is unable to locate the file.

The output string is also modifyable. You can vary the variables for the `Rank`, `Username`, `VIs`, `Time`, and `Rerecords`, as seen in the `Settings` window:

![img 10](https://i.imgur.com/voGKLOv.png)

Clicking the help button wil also explain that you must have an equal number of "variable" `{0}`, `{1}`, `{2}`, etc. as there are boxes checked, or the program may crash or function incorrectly. Each check box from left to right is smallest to largest number going from `{0}` to how ever many variables are enabled. For example, having only `Rank` and `Username` checked means you only need to use `{0}` and `{1}`.

However, you can mix these variables up. So, if you want the format:
"`Username` || \~`Rank`\~", you would write: "`{1}` || \~`{0}`\~".
An example would look like "`TimeTravelPenguin` || \~`2nd`\~".



