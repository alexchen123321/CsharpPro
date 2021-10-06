# .NET MVC initialize 

### 1. Install  Depency Packages
```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Proxies
```


### 2. Model
```
public class <ModelName>
{
    public <ModelName>()
        Id = new Guid();
    }
    !/* maps to primary key !*/
    public Guid Id { get; set; }
    !/* maps to N table-columns !*/
    public <data_type> <property_name1>  { get; set; }
    public <data_type> <property_name2>  { get; set; }
    !!...
    public <data_type> <property_nameN>  { get; set; }
}

```
Create Song Model in Models Folder
```
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace StreamingIndustry.Models
{
    public class Song
    {
        public Song()
        {
            Id = new Guid();
        }
        /* maps to primary key */
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public int Mins { get; set; }
        [Required]
        public int Secs { get; set; }

        /* navigational property: One-to-One relationship to Genre */
        public virtual Genre Genre { get; set; }
    }
}
```

