1. Current version: 2.0.2000
2. Code Folder Name: avalondock-102592\Version2.0
3. Changed File:
	DockingManager.cs: The change is for creating a new transformation pane when drag/drop a table from schema tree view.
	LayoutItem.cs: The change is for adding DirtyIndicator dependency property which will add "*" beside the title when transformation is dirty
	generic.xaml:	1. The change is for adding automationid.
					2. Change the default margin of ContentPresenter from Margin="{TemplateBinding Padding}" to zero
					3. Adjust the Header position since we change the default margin
					4. Customize the TabItem template, add DirtyIndicator "*" to LayoutDocumentTabItem



