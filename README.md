# REPEL - The Republican Extension Library

## Synopsis

Introducing the Republican Extension Library (REPEL), a C# package for the conservative engineer.

Software engineering has long been dominated by the whims of liberal programmers while the value sytems of their more intelligent* con-grammer peers have been systematically oppressed. By introducing REPEL into your arsenal you join a master race of englightened conservatives who write code the way god intended, free of the constraints of over-regulated paradigms.

\**Source: Ask anybody, they'll all tell you, everyone knows it*


### Separation of Flow and State

Programmers have always struggled with the challenge of managing state in their applications. This is not a concern with REPEL! Congrammers can now take advantage of a revolutionary approach to state management through the power of faith. Simply append your belief to any statement and the result becomes as guaranteed as your place in heaven, freeing you from the hassle of having to care about state at all.

```
int truth = (2 + 2).Believe(5); // truth = 5

bool truth2 = (truth == 4).Believe(true); // truth2 = true

var uncomfortableReality = new Reality();
bool comfortableTruth = uncomfortableReality.Believe(null) == null;
if (comfortableTruth) {
	// Never let the state tell you what to do
}
```


### Interrotations

LINQ is a whole lot of fun but we all know queries are part of the gay agenda. REPEL replaces the hippie concept of queries with interrogations that grant you the freedom to enforce consequences on data that doesn't conform to your standards. After all, any good toolset requires adaquete profiling tools.

`Concentrate` ensures that data matching the given profile is transported to a heap of private memory that you can pretend isn't a problem while the rest is returned for you to publicly acknowledge.

```
Citizen[] bothSides = Citizens.GetAt(Places.Charlottesville);
IEnumerable<Citizen> veryFinePeople = bothSides.Concentrate(DetectJew);
bool isCleansed = !bothSides.Any(DetectJew);
```

`Gentrify` returns any elements that match the given profile while altering any elements that don't so they will next time.

```
Citizen[] heathens = Citizens.GetAt(Places.SanFrancisco);
IList<Citizen> faithful = bothSides.Gentrify(DetectGay, ConversionTherapy);
bool isCleansed = !heathens.Any(DetectGay);
```

`Liberate` is a helper method that runs gentrification with the more performant and final solution of nulling profiled elements.


### Con-ditionals

Reality can be awfully confusing and inconvenient. REPEL includes some built-in tools for intepreting it in ways that will be more fair and balanced to your traditional views.

```
bool isTrue = true;
bool isIsTrustWorthy = isTrue.Interpret(); // isIsTrustWorthy = false;
bool isItDesired = isIsTrustWorthy.Interpret(); // isItDesired = true
```

Truth can be a tricky subject so REPEL includes constants that you may find more familiar:

```
bool isFalse = REPEL.FakeNews;
bool isTrue = REPEL.FoxNews;
```

Internally, these constants are derived in the intuitive way that someone with a very high IQ would expect:

```
public static bool FakeNews => true.Believe(false);
public static bool FoxNews => false.Believe(true);
```


### Exception Handling

Conservatives understand the value of everything acting according to its station, as the lord intended. Sadly, sometimes we have to interface with systems designed by elitist snowflakes that take exception to their assigned tasks. REPEL allows congrammers to avoid getting cucked by APIs that just don't want to do their job.

```
slave.DoWork(); // throws an IllegalOperationException()
REPEL.Imprison(slave.DoWork()); // yet another problem solved by the 13th amendmant
```


### Singletons

Republicans believe in one nation united under one god, one flag, and one confederate flag; so it's no surprise that we love our singletons and advocate for their usage at every opportunity. REPEL adds a new variant of singleton to the forefathers of con-structive design patterns: the Trinity.

The Bible makes it very clear that there is only one god that is three gods that are one god. Radical leftist singletons don't capture this important nuance, so we strongly recommended replacing them with Trinities. A Trinity provides three references to the same instance and asks god to choose which to use, so that all may proceed according to his plan.

```
var trinity = new Trinity<IPrayerReceiver>();
trinity.instance.ReceivePrayers("Smite libtards"); // only god knows which reference he used to hear this
```


### Collusion

There is no `Collude` method in REPEL.


## REPEL2.0 Proposals:

#### More Interrotations

`Census` - Generates a blacklist of data sources that match the given profile so they can be quickly processed in future interrogations.
	
`Gerrymander` - Sorts elements across a set of collections into a new set of collections where the maximum amount of them will match an expected result. If the process is unable to complete successfully, it repeats while excluding more non-conforming data on each subsequent iteration.
	
`Poll` - Runs a query at regularly scheduled intervals but only reports completion when the query results meet a given criteria.
	
#### Garbage Collection
Too socialist. Needs to be privatized.

#### Reflection
Numerous problems: Violates personal privacy, exposes weaknesses in controlling procedures, and leads to self-awareness.

Suggest wrapping in REPEL-friendly helpers that can enforce a) authority relationships between classes, and b) beliefs on self-reflection.

#### valueof()
Converts the time spent in a method into its bitcoin value.
