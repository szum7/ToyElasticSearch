# ToyElasticSearch
Experiment with elasticsearch.

## Dev history
1. Create a .NET Core WebApi
2. Add the .yml file
3. Install the nuget packages
4. Code

## How to use
1. Run `docker-compose`
2. Run the application
3. Call the controller endpoints to generate logs
4. Visit Kibana and see the logs

### Urls
- Kibana | http://localhost:5601/app/home#/
- Elasticsearch | http://localhost:9200/

### Additional info
#### Max virtual memory too low issue
```
// Navigate to the project
> cd ...

// Enter the VM
wsl -d docker-desktop

// Extend the max vmemory
sysctl -w vm.max_map_count=262144

// Exit the VM
exit
```
[Stackoverflow source](https://stackoverflow.com/questions/51445846/elasticsearch-max-virtual-memory-areas-vm-max-map-count-65530-is-too-low-inc)

### Sources
[Logging into Elasticsearch using Serilog and viewing logs in Kibana | .NET Core Tutorial](https://youtu.be/0acSdHJfk64)
