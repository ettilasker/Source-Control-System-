using DesignPatternsProject;
Console.WriteLine("Hello, World!");

Branch mainBranch=new Branch("mainBranch");
Branch childBranch = new Branch("childBranch");
mainBranch.CreateBranch("ettiBranch");
mainBranch.CreateBranch("chaviBranch");
mainBranch.CreateBranch("leebaBranch");

List<Item> items = new List<Item>();
items.Add(new Folder(" "));
items.Add(new Files(" "));

var HasAccess = new Access();
mainBranch.Attach(HasAccess);
mainBranch.Notify();

mainBranch.BranchToCommit();
mainBranch.BranchToMerge();
mainBranch.state = new Committed();


var caretaker = new Caretaker(mainBranch);
var caretaker1 = new Caretaker(childBranch);
caretaker.Backup();
caretaker.ShowHistory();
caretaker.Undo();
caretaker.ShowHistory();





