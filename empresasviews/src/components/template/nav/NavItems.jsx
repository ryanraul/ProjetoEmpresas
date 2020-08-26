import React from 'react'

export default props=>
<a href={`#/${props.rout}`} className={`fa fa-${props.icone}`}><span className="font-nav">{props.titulo}</span></a>