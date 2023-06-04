import React from 'react'
import Button from '@mui/material/Button';
import { Container } from '@mui/material';

function Login() {
  return (
    <Container
        maxWidth="sm"
        sx={{
            display: 'flex',
            justifyContent: 'center',
            alignItems: 'center',
            minHeight: '100vh',
        }}
    >
        <Container
            sx={{
                display: 'flex',
                flexDirection: 'column',
                alignItems: 'center',
                justifyContent: 'center'
            }}>
            <h1>Login</h1>
            <Button variant='contained'>Click Me</Button>
        </Container>
    </Container>
  )
}

export default Login