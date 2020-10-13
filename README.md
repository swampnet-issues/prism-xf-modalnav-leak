# prism-xf-modalnav-leak

### Replicate possible memory leak when using modal navigation.

Honestly don't know if this a Forms thing, a Prism thing or, more than likely, a me thing.

New Prism XF project from template. Add a few pages and wire up to commands on mainpage.

Xamarin Forms Profiler snapshots after navigating to (and then back from) ChildOnePage (standard navigation) and ChildTwoPage (modal) a total of 5 times each (between snapshots 1 & 2. 0 is just my baseline).

![Xamarin Forms Profiler](https://github.com/swampnet-issues/prism-xf-modalnav-leak/blob/master/img/screenshot-01.png)

ChildOnePage (normal navigation) has zero allocations, ChildTwoPage (modal) still has five.

![Xamarin Forms Profiler](https://github.com/swampnet-issues/prism-xf-modalnav-leak/blob/master/img/screenshot-02.png)

```
private DelegateCommand _navigateCommand;
public DelegateCommand NavigateCommand => _navigateCommand ?? (_navigateCommand = new DelegateCommand(Navigate));
private async void Navigate()
{
    await NavigationService.NavigateAsync("ChildOnePage");
}


private DelegateCommand _navigateModalCommand;
public DelegateCommand NavigateModalCommand => _navigateModalCommand ?? (_navigateModalCommand = new DelegateCommand(NavigateModal));
private async void NavigateModal()
{
    await NavigationService.NavigateAsync("ChildTwoPage", useModalNavigation: true);
}
```