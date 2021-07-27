import{Pipe,PipeTransform} from '@angular/core'

@Pipe(
    {
        name:'productfilterpipe'
    }
)
export class ProductFilterPipe implements PipeTransform
{
    transform(products:any,searchText:any)
    {
        if(searchText)
        {
            return products.filter(x=>x.pname.toLowerCase().startsWith(searchText.toLowerCase()));
         
        }
    }

}