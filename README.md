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

![alt text](http://imgs.fyi/img/6t2b.png)

To begin, start by filling out the textboxes, then hitting the **ADD** button to add them to the datagrid.
You can, if desired chose disqualification reasons, should the user who submit have broken the rules of the competition.

![alt text](http://imgs.fyi/img/6t2c.png)

Once added, items should automatically sort themselve such that the smallest time is ranked 1st. DQ'd submissions are all equally ranked last.

![alt text](http://imgs.fyi/img/6t2e.png)

Naturally, you can see what the comments are by hovering over the comments cell

![alt text](http://imgs.fyi/img/6t2f.png)

You can indevidually open/save both the competition leaderboards and points leaderboards into a custom .TASc and .TASs file, respectively. The different file extensions help to distinguinsh each type of file.

![alt text](http://imgs.fyi/img/6t2g.png)

By hitting the "Score Points" button in the top toolbar, scores all the runners in the compeition. If you have a .TASs file open, the scores of existing users are added to their previous score. If not, they are added as a new user. Users who have been DQ'd will not score any points. The current scoring formula is the one seen [here](https://docs.google.com/spreadsheets/d/e/2PACX-1vSL-uZkslyP4tnQcprS_aR1-ZQNduVH3MvdpVyiAZPWA9g25RlyhlJVMNri3r3HqrmVhyb54Mw1pAlt/pubhtml).

![alt text](http://imgs.fyi/img/6t2h.png)

Once ready to export to release the results of the competition, you can chose what to export as plaintext from the "Export Plain Text" toolbar option. You can export both the competition and points leaderboards.

![alt text](http://imgs.fyi/img/6t2o.png)

Depending on the number of submitees, the number of bolded names at the top of each list changes. The competition export has a max of 5, where the point export has a max of 3 bolded names.

![alt text](http://imgs.fyi/img/6t2p.png)

