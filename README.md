# Multiple Steps

Multiple Steps form in ASP.NET MVC. designed for progress tab in mvc.

### How to use

For starting, first add `MultipleStepProgressTabOption` class to your project and then add below method to your `HtmlHelperExtensions` class:

```
public static MvcHtmlString MultipleStepProgressTab(
            this HtmlHelper htmlHelper, 
            MultipleStepProgressTabOption opt)
{
   /* BODY IS IN THIS PROJECT [HtmlHelperExtensions] CLASS */
}
```

So you can to get a step control on mvc view. For this work, add this sample codes to your view or controller as model:

```
  // Sample Mvc Controller
  public ActionResult Index()
  {
      var opt = new MultipleStepProgressTabOption()
      {
          Steps = new List<string>()
          {
              "Step 1",
              "Step 2",
              "Step 3",
              "Step 4",
              "End Step"
          },
          CurrentStepIndex = 3            
      };
      return View(opt);
  }
```

And for use in mvc View:


```
   @model MultipleStepProgressTabOption
  
   @Html.MultipleStepProgressTab(Model)
```


Sample Result:

![sample multiple steps image](https://raw.githubusercontent.com/Behzadkhosravifar/MultipleStep/master/img/sample.PNG)
