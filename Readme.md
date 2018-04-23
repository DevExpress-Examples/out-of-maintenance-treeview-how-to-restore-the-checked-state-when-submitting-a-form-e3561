# TreeView - How to restore the checked state when submitting a form


<p>TreeView does not have the built-in capability to restore the checked state when submitting a form. This example illustrates how to do this manually.</p><p>To accomplish this task, execute the following steps:</p><p>- Place the hidden input on a form;<br />
- Obtain the checked TreeView values in the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxTreeViewScriptsASPxClientTreeView_CheckedChangedtopic"><u>ASPxClientTreeView.CheckedChanged</u></a> event handler and add them to the input value;<br />
- To get the checked values, use the following code:</p>

```js
function ListCheckedNodes(parent) {<newline/>
   for (var i = 0; i < parent.GetNodeCount(); i++) {<newline/>
       if (parent.GetNode(i).GetChecked()) {<newline/>
           checkedNodes.push(parent.GetNode(i).GetText());<newline/>
       }<newline/>
       if (parent.GetNode(i).GetNodeCount() != 0) {<newline/>
           ListCheckedNodes(parent.GetNode(i));<newline/>
       }<newline/>
   }<newline/>
}<newline/>

```

<p>- Bind the input value to Model:</p>

```aspx
<input type="hidden" id="hf" name="hf" value='@Model' />
```

<p> </p>

```cs
CheckedValues = Request.Params["hf"];<newline/>
return View("Index", CheckedValues);<newline/>

```

<p>- In the client-side TreeView Init event handler, restore the checked state as follows:</p>

```js
var checkedValues = new Array();<newline/>checkedValues = hf.value.split(";");<newline/>for (x in checkedValues) {<newline/>    var node = s.GetNodeByText(checkedValues[x]);<newline/>    node.SetChecked(true);<newline/>}<newline/>
```

<p> </p>

<br/>


