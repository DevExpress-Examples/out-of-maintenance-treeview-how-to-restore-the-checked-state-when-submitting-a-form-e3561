var checkedNodes;
function tvFeatures_OnCheckedChanged(s, e) {
    var hf = document.getElementById("hf");
    checkedNodes = new Array()
    ListCheckedNodes(s);
    hf.value = checkedNodes.join(";");
}
function ListCheckedNodes(parent) {
    for (var i = 0; i < parent.GetNodeCount(); i++) {
        if (parent.GetNode(i).GetChecked()) {
            checkedNodes.push(parent.GetNode(i).GetText());
        }
        if (parent.GetNode(i).GetNodeCount() != 0) {
            ListCheckedNodes(parent.GetNode(i));
        }
    }
}
function tvFeatures_OnInit(s, e) {
    var hf = document.getElementById("hf");
    if (hf.value == "")
        return;
    var checkedValues = new Array();
    checkedValues = hf.value.split(";");
    for (x in checkedValues) {
        var node = s.GetNodeByText(checkedValues[x]);
        node.SetChecked(true);
    }
}