# prism-xf-modalnav-leak

Replicate memory leak when using modal navigation

Snapshots after navigating to (and then back from) ChildOnePage (standard navigation) and ChildTwoPage (modal) a total of 5 times each.

![Test Image 7](https://github.com/swampnet-issues/prism-xf-modalnav-leak/blob/master/img/screenshot-01.png)

ChildOnePage has zero allocations, ChildTwoPage still has five.

![Test Image 7](https://github.com/swampnet-issues/prism-xf-modalnav-leak/blob/master/img/screenshot-02.png)
