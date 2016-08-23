<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

//Connected Scenario:Connected scenario is when an entity is retrieved from 
//the database and modified in the same context.   
//
//Disconnected Scenario:Disconnected scenario is when an entity is retrieved 
//from the database and modified in the different context. Disconnected scenario
//is complex because context doesn’t know anything about modified entity so
//you have to tell to ObjectContext that what has changed in entity.