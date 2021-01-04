function VendorButtons(index) 
{
    let vendorDiv = document.getElementById('vendor_select_box');
    // jestli je vendorIndex definovaný - jestli už je nějaký tlačítko "rokliklé"
    if (typeof vendorIndex === 'number')
    {
        // jestli se kliklo na stejný tlačítko
        if (index == vendorIndex) 
        {
            vendorDiv.children[index].style.color = 'black';
        }
        // kliklo se na jiný tlačítko
        else 
        {
            vendorDiv.children[vendorIndex].style.color = 'black';
            vendorDiv.children[index].style.color = 'var(--myPink)';
        }
        
    }
    // na žádné tlačítko se ještě nekliklo
    else 
    {
        vendorIndex = index;
        /*for (let i = 0; i < index; i++) 
        {
            vendorDiv.children[i].style.color = 'black';
        }*/
        vendorDiv.children[index].style.color = 'var(--myPink)';
    }
}

function MakeVendorButton(vendorName) 
{
    let vendorDiv = document.getElementById('vendor_select_box');
    if (typeof vendorIndex === 'number')
    {
        vendorDiv.children[vendorIndex].style.color = 'var(--myPink)';
        console.log('button is pressed');
    }
    let i = 0
    let index = null;
    while (true)
    {
        if (vendorDiv.children[i].innerHTML === vendorName)
        {
            index = i;
            break;
        }
        i++;
    }
}

MakeVendorButton();

